import { Component, OnInit, Injectable } from '@angular/core';
import { GiantBombApiImportService } from '../shared/services/giant-bomb-api-import.service';

@Component({
  selector: 'app-import-platform',
  providers: [  ],
  templateUrl: './import-platform.component.html',
  styleUrls: ['./import-platform.component.css']
})
export class ImportPlatformComponent implements OnInit {


  private platForms: [{key, value}] =
    [{key: 'id', value: ['19']}];

  constructor(private _giantBombImportService: GiantBombApiImportService) {
   }

  ngOnInit() {

  }

  importPlatforms() {
  //   this._giantBombImportService.getAll('platforms', this.platForms).subscribe(data => {
  //     console.log(data);
  //   });

    this._giantBombImportService.getAll('platforms', this.platForms).subscribe(data => {
      console.log(data);
    });
  }
}
