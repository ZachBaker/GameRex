import { RouterModule, Routes } from '@angular/router';
import { NgModule } from '@angular/core';
import { ImportGameComponent } from './import-game/import-game.component';
import { ImportPlatformComponent } from './import-platform/import-platform.component';
import { CoreModule } from '../core/core.module';
import { ImportCompanyComponent } from './import-company/import-company.component';

const importRoutes: Routes = [
    { path: 'import/platform', component: ImportPlatformComponent},
    { path: 'import/game', component: ImportGameComponent},
    { path: 'import/company', component: ImportCompanyComponent}
  ];

  @NgModule({
    imports: [
      RouterModule.forChild(
        importRoutes
      ),
      CoreModule
    ],
    exports: [
        RouterModule
    ]
  })
  export class ImportRoutingModule { }
