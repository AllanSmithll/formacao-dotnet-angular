import { Component, Input, OnInit } from '@angular/core';
import { Cardapio } from '../../models/cardapio'

@Component({
  selector: 'app-cardapio',
  templateUrl: './cardapio.component.html',
  styleUrls: ['./cardapio.component.scss']
})
export class CardapioComponent implements OnInit {

  @Input() cardapio?: Cardapio;

  constructor() { }

  ngOnInit(): void {
  }

}
