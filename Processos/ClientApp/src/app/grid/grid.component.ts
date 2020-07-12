import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-grid',
  templateUrl: './grid.component.html'
})

export class GridComponent implements OnInit {
  title = 'Grid';

  columnDefs = [
    { headerName: 'Codigo', field: 'codigo' },
    { headerName: 'Número do Processo', field: 'numeroDoProcesso' },
    { headerName: 'Data De Criação do Proesso', field: 'dataDeCriacaoDoProcesso' },
    { headerName: 'Valor', field: 'valor' },
    { headerName: 'Escrito', field: 'escritorio' }
  ];

  rowData: any;

  constructor(private http: HttpClient) {

  }

  ngOnInit() {
    this.rowData = this.http.get('https://localhost:5001/v1/ListarProcesso');
  }
}



