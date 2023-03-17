import { NgModule,CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule} from '@angular/common/http'
import { AppComponent } from './app.component';
import { HomeComponent } from '../app/home/home.component';
import { MovieListComponent } from './movie-list/movie-list.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { AngularMaterialModule } from './angular-material.module';
import { RegisterComponent } from './UserLogin/register/register.component';
import { FlexLayoutModule } from '@angular/flex-layout';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { SigninComponent } from './UserLogin/signin/signin.component';
import {MatNativeDateModule } from '@angular/material/core';
import { MatMomentDateModule } from '@angular/material-moment-adapter';
import { MatTooltipModule } from '@angular/material/tooltip';
import { JwtModule } from "@auth0/angular-jwt";
import { AuthGuard } from './auth/auth-gaurd.service';
export function tokenGetter() {
  return localStorage.getItem("token");
}
@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,      
    MovieListComponent,
    
    RegisterComponent,
    SigninComponent
  ],
  exports:[
    
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    BrowserAnimationsModule,
    AngularMaterialModule,
    AppRoutingModule,
    FlexLayoutModule,
    FormsModule,ReactiveFormsModule,
    MatNativeDateModule,
    MatMomentDateModule,
    JwtModule.forRoot({
      config: {
        tokenGetter: tokenGetter,
        allowedDomains: ["localhost:7067"],
        disallowedRoutes: []
      }
    })

  ],
  providers: [AuthGuard],
  bootstrap: [AppComponent],
 schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class AppModule { }
