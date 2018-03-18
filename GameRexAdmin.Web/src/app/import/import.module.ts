import { NgModule, Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ImportComponent } from './import/import.component';
import { ImportPlatformComponent } from './import-platform/import-platform.component';
import { ImportGameComponent } from './import-game/import-game.component';
import { Routes, RouterModule } from '@angular/router';
import { ImportRoutingModule } from './import-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { GiantBombApiImportService } from './shared/services/giant-bomb-api-import.service';
import { BrowserModule } from '@angular/platform-browser';
import { ImportCompanyComponent } from './import-company/import-company.component';
import { IgdbApiImportService } from './shared/services/igdb-api-import.service';

@NgModule({
  imports: [
    CommonModule,
    BrowserModule,
    ImportRoutingModule
  ],
  declarations: [ImportComponent, ImportPlatformComponent, ImportGameComponent, ImportCompanyComponent],
  providers: [GiantBombApiImportService, IgdbApiImportService]
})
export class ImportModule { }
