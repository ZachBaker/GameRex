import { Component, OnInit } from '@angular/core';
import { GiantBombApiImportService } from '../shared/services/giant-bomb-api-import.service';
import { IgdbApiImportService } from '../shared/services/igdb-api-import.service';

@Component({
  selector: 'app-import-company',
  templateUrl: './import-company.component.html',
  styleUrls: ['./import-company.component.css']
})
export class ImportCompanyComponent implements OnInit {


  constructor(private _giantBombImportService: GiantBombApiImportService,
  private _igdbImportService: IgdbApiImportService) { }

  ngOnInit() {
  }

  importCompanies() {
    this._igdbImportService.get('companies').subscribe( data => {
      console.log(data);
    });
  }
}
