using Microsoft.AspNetCore.Mvc;


public class TestController:Controller{

  private readonly Dbcontent _content;
  public TestController(Dbcontent _content){
     this._content = _content;
  }

[Route("/")]
[HttpGet]
public string test() =>"hello";

[Route("/login")]
[HttpGet]
public IActionResult login(){

  return Ok();
}

[Route("/Reasource")]
[HttpGet]
public IActionResult list() => Ok(_content.resource.ToList());

}