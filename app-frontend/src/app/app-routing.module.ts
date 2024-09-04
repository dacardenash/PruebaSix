import { NgModule } from '@angular/core';
import {RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './user/home/home.component';

const routes: Routes = [
    {path: 'user/home', component:HomeComponent},
    {path: 'user', redirectTo:'user/home', pathMatch: 'full'},
    {path: '', redirectTo:'user/home', pathMatch: 'full'}

];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})

export class AppRoutingModule {}