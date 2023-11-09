using System.Collections;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TelegramApp.Models;

namespace TelegramApp.Repository;
public class PostsRepository:IEnumerable
{
    private List<Post> Posts { get; set; }
    public PostsRepository()
    {
        Posts = new List<Post>(){
            new ImportantPost(1,"Calisma",6,10),
            new ImportantPost(2,"Calisma",7,11),
            new ImportantPost(3,"Calisma",8,12),
            new ImportantPost(4,"Calisma",9,13)
        };
    }
    public List<Post>? GetAllPosts(){
        return Posts;
    }

    public PostsRepository(List<Post> posts)
    {
        foreach (var item in posts)
        {
            AddOnePost(item);
        }
    }
    public void AddOnePost(Post post){
        Posts.Add(post);
    }
    public List<Post> SortBySize(){
        Posts.Sort();
        return Posts;
    }
    public Post GetOnePost(int id){
       try
       {
       var post =  Posts.SingleOrDefault(pos=>pos.Id.Equals(id));
        if (post == null){
            throw new PostNotFoundException(id);
        }
        else
        {
            return post;
        }
        
       }
       catch (System.Exception ex)
       {
        
        throw new Exception(ex.Message);
       }
    }
   /*  public IActionResult GetOnePost(int id){
        return Posts.Single(pos=>pos.Id.Equals(id));
    } */

    public IEnumerator GetEnumerator()
    {
        return Posts.GetEnumerator();
    }

}