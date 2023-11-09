using Microsoft.AspNetCore.Mvc;
using TelegramApp.Models;
using TelegramApp.Repository;

namespace TelegramApp.Controllers;
[ApiController]
[Route("/api/posts")]
public class PostController:ControllerBase
{
    private readonly PostsRepository postsRepository;

    public PostController(PostsRepository postsRepository)
    {
        this.postsRepository = postsRepository;
    }
    [HttpGet]
    public IActionResult GetAllPosts(){
        var posts = postsRepository.GetAllPosts();
        return posts == null?NotFound("There is no items in the list"):Ok(posts);
    }
    [HttpGet("{id:int}")]
    public Post GetOne(int id){
        return postsRepository.GetOnePost(id);
    }
    [HttpPost]
    public void AddOnepost(Post post){
        postsRepository.AddOnePost(post);
    }
}