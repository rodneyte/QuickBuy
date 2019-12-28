import {Component} from "@angular/core"

@Component({
  selector: "app-produto",
  template:"<html><body>{{obterNome()}}}<body/><html/>"
})






export class ProdutoComponent {//Nome das classes começa com maiusculas por conta da convenção PascalCase
/* camelCase para variaveis,atributos e nomes de funçôes */
  public nome: string;
  public liberadoParaVenda: boolean;

  public obterNome(): string {
    return this.nome;
  }

}
