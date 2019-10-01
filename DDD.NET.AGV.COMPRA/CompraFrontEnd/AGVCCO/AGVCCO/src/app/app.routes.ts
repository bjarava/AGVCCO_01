import { Routes, RouterModule } from '@angular/router';
import { NavbarComponent } from './components/navbar/navbar.component';
import { ProductComponent } from './components/product/product.component';
import { Route } from '@angular/compiler/src/core';
import { from } from 'rxjs';
import { HomeComponent } from './components/home/home.component';


// Constante rutas
const APP_ROUTES: Routes = [
    {path: 'home', component: HomeComponent},
    {path: 'navbar', component: NavbarComponent},
    {path: 'product', component: ProductComponent},
    {path: 'about', component: ProductComponent},
    {path: 'car', component: ProductComponent},
    {path: '**', pathMatch: 'full', redirectTo: 'home'}
];

export const APP_ROUTING = RouterModule.forRoot(APP_ROUTES, {useHash: true});
