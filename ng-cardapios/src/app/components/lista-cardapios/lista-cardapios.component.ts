import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-lista-cardapios',
  templateUrl: './lista-cardapios.component.html',
  styleUrls: ['./lista-cardapios.component.scss']
})
export class ListaCardapiosComponent implements OnInit {

  cardapios = [
    {
      imagem: "",
      titulo: "Cardápio 01",
      descricao: "",
      telefone: ""
    },
    {
      imagem: "",
      titulo: "Cardápio 02",
      descricao: "",
      telefone: ""
    },
    {
      imagem: "",
      titulo: "Cardápio 03",
      descricao: "",
      telefone: ""
    },
    {
      imagem: "",
      titulo: "Cardápio 04",
      descricao: "",
      telefone: "",
    }
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
