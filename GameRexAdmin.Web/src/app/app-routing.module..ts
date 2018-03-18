import { ImportComponent } from './import/import/import.component';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

const appRoutes = [
    { path: 'import',  component: ImportComponent}
  ];

@NgModule({
    imports: [
    RouterModule.forRoot(
        appRoutes,
        {enableTracing: false}
      ),
    ],
    exports: [
        RouterModule
    ]
})

export class AppRoutingModule {}
