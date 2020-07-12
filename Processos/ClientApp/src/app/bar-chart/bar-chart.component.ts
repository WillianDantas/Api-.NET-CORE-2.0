import { Component, OnInit, Injectable } from '@angular/core';
import { ChartOptions, ChartType, ChartDataSets } from 'chart.js';
import * as pluginDataLabels from 'chartjs-plugin-datalabels';
import { Label } from 'ng2-charts';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { HttpErrorResponse } from '@angular/common/http';
import { BarChartService } from './bar-chart.service';

@Component({
  selector: 'app-bar-chart',
  templateUrl: './bar-chart.component.html',
})

@Injectable()
export class BarChartComponent implements OnInit {
  public barChartOptions: ChartOptions = {
    responsive: true,
    // We use these empty structures as placeholders for dynamic theming.
    scales: { xAxes: [{}], yAxes: [{}] },
    plugins: {
      datalabels: {
        anchor: 'end',
        align: 'end',
      }
    }
  };

  public barChartLabels: Label[] = ['Escritorio'];
  public barChartType: ChartType = 'bar';
  public barChartLegend = true;
  public barChartPlugins = [pluginDataLabels];

  //public barChartData: ChartDataSets[] = [
  //  { data: [65], label: 'Series A' },
  //  { data: [28], label: 'Series B' }
  //];


  public barChartData = [];



  constructor(private _bar: BarChartService) {
   
  }


  //ngOnInit() {
  //  this.http.get('https://localhost:5001/v1/Grafico', { responseType: 'json' }).subscribe(
  //    data => {
  //      this.barChartData.pop(JSON.parse(JSON.stringify(data)))	 // FILL THE CHART ARRAY WITH DATA.
  //      console.log(JSON.parse(JSON.stringify(data)));
  //    },
  //    (err: HttpErrorResponse) => {
  //      console.log(err.message);
  //    }
  //  );
  //}


  ngOnInit() {

    this._bar.getBar()
      .subscribe(res => {
        var bar = []
        let retorno = res["retorno"]
        retorno.forEach((res) => {
          console.log({ data: [res.data], label: res.label })
          bar.push({ data: [res.data], label: res.label })
          console.log(bar)
          this.barChartData = bar;
        })
        
      })
  }


  

  // events
  //public chartClicked({ event, active }: { event: MouseEvent, active: {}[] }): void {
  //  console.log(event, active);
  //}

  //public chartHovered({ event, active }: { event: MouseEvent, active: {}[] }): void {
  //  console.log(event, active);
  //}

  //public randomize(): void {
  //  // Only Change 3 values
  //  const data = [
  //    Math.round(Math.random() * 100),
  //    59,
  //    80,
  //    (Math.random() * 100),
  //    56,
  //    (Math.random() * 100),
  //    40];
  //  this.barChartData[0].data = data;
  //}
}
