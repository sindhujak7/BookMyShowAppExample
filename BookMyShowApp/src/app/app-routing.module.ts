import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { Routes, RouterModule } from '@angular/router';
// Import all the components for which navigation service has to be activated 
import { HomeComponent } from '../app/home/home.component';
import { LoginComponent } from './UserLogin/login/login.component';
import { RegisterComponent } from './UserLogin/register/register.component';
const routes: Routes = [
  { path: 'login', component:LoginComponent },
  { path: 'home', component: HomeComponent },  
  { path: 'register', component: RegisterComponent }
  //{ path: '**', component: HomeComponent } // If no matching route found, go back to home route
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
