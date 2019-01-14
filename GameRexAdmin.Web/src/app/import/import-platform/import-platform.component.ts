import { Component, OnInit, Injectable } from '@angular/core';
import { GiantBombApiImportService } from '../shared/services/giant-bomb-api-import.service';
import { HttpService } from '../../core/services/http-service.service';
import { Platform } from '../shared/models/platform';
import { Platforms } from '../shared/models/platforms';

@Component({
  selector: 'app-import-platform',
  providers: [  ],
  templateUrl: './import-platform.component.html',
  styleUrls: ['./import-platform.component.css']
})
export class ImportPlatformComponent implements OnInit {


  private platForms: [{key, value}] =
    [{key: 'id', value: ['19']}];

  constructor(private _giantBombImportService: GiantBombApiImportService,
              private _httpService: HttpService) {
   }

  ngOnInit() {

  }

  importPlatforms() {

    this._giantBombImportService.getAll('platforms', this.platForms).subscribe(data => {
      console.log(data);

      const platforms = new Platforms();
      platforms.platforms = data;

      console.log(platforms);

      this._httpService.post('platform', platforms);

    });
  }
}
