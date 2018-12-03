import { Component, OnInit } from '@angular/core';

import JoggingRecord from '../shared/JoggingRecord';
import ApiService from '../shared/api.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit  {
  joggingRecords: Array<JoggingRecord>;

  constructor(private apiService: ApiService) {
  }

  ngOnInit() {
    this.apiService.getAll().subscribe(data => {
      this.joggingRecords = data;
    });
  }
}
