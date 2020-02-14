
import { Component } from "@angular/core"

@Component({

  selector: "produto",
  template:"<html><body>{{obterDados()}}</body></html>"

})

export class ProdutoComponent {

  public nome: string;
  public descricao: string;


  public obterDados(): string {

    return "Monitor";
  }


}
