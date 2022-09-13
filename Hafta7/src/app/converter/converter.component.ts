import { Component } from '@angular/core';

@Component({
  selector: 'app-converter',
  templateUrl: './converter.component.html',
  styleUrls: ['./converter.component.css']
})

export class ConverterComponent {
  currencies: String[] = ['TRY', 'USD', 'EUR', 'GBP'];
  inCurrency: String="TRY";
  outCurrency: String="USD";
  input:number=0;
  exchangeRates: any = {
    TRY: 1,
    USD: 13.57,
    EUR: 15.53,
    GBP: 18.37
  };

  constructor() { }

  ngOnInit(): void {
  }

  convert(input:number, inCurrency:any, outCurrency:any):number {
    return (input*((input*this.exchangeRates[inCurrency]) /
    (input*this.exchangeRates[outCurrency]))).toFixed(2) as any;

  }
}
