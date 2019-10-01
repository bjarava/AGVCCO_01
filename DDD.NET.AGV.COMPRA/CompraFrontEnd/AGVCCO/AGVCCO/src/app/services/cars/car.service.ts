import { Injectable } from '@angular/core';
import { HttpClient, HttpHandler } from '@angular/common/http';
import { Car } from '../../models/cars/car';
import { RequestResponse } from '../../models/common/request-response';
import { from } from 'rxjs';

/**Etiqueta de Angular */
@Injectable({providedIn: 'root'})


/**Servicio del carrito */
export class CarService {
    /**Constructor */
    constructor(private http: HttpClient) {
        console.log('Constructor de servicio de carrito iniciado');
        /*this.GetCar();*/
        }
    car: Car;
    requestResponse: RequestResponse;

    /**Obtener carrito */
    GetCarAdd(state: string, carusu: number) {
       return this.http.get('http://localhost:54071/api/car/get/' + state + '/' + carusu );
    }

    /**Adicionar al carrito */
    public AddCar(car: Car) {
       return this.http.post<RequestResponse>('http://localhost:54071/api/car/post', car);
    }
}
