import { Component } from "@angular/core"
import { Usuario } from "../../model/usuario";




@Component({

  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]

})
export class LoginComponent{

  public usuario;
  public autenticationLogin: boolean;
 // public usuarios = ["usuario1","usuario2","usuario3","usuario4"];

  constructor () {

    this.usuario = new Usuario()

}

  entrar():void {

    //alert(this.usuario.email + ' ' + this.usuario.senha);

    if
      (this.usuario.email == "markosvolg@gmail.com" && this.usuario.senha == "@123456") {

      this.autenticationLogin = true;

    }
  }
  

}
