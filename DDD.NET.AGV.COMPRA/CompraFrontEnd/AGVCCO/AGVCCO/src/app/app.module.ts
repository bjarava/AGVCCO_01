import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


//Rutas
 import { APP_ROUTING } from './app.routes';

//Servicios
import { ProductService } from './services/products/product.service';


//Componentes
import { AppComponent } from './app.component';
import { NavbarComponent } from './components/navbar/navbar.component'; 
import { ProductComponent } from './components/product/product.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { HomeComponent } from './components/home/home.component';
import { AboutComponent } from './about/about.component';
import { CarComponent } from './components/car/car.component';
import { CarService } from './services/cars/car.service';
import { UserComponent } from './components/user/user.component';
import { UserService } from './services/users/user.service';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    ProductComponent,
    HomeComponent,
    AboutComponent,
    CarComponent,
    UserComponent
  ],
  imports: [
    BrowserModule,
    APP_ROUTING,
    HttpClientModule,
    FormsModule
  ],
  providers: [
    ProductService,
    CarService,
    UserService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
