using Microsoft.AspNetCore.Mvc;


public class TestController:Controller{

[Route("/")]
[HttpGet]
public string test() =>"hello";

[Route("/login")]
[HttpGet]
public IActionResult login(){

  return Ok();
}


private void addresources(){

}

}