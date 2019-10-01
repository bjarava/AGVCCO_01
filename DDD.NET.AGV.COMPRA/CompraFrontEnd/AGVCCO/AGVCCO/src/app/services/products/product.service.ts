import { Injectable } from '@angular/core';
import { HttpClient, HttpHandler } from '@angular/common/http';

@Injectable({providedIn: 'root'})

/**Servicios de productos */
export class ProductService {
    /**
     * Constructor
     * @param http ;
     */
    constructor(private http: HttpClient) {
        console.log('Servicio listo');
        this.GetAllPro();
    }
    /**
     * Obtener todos lista de productos
     */
    GetAllPro() {
        return this.http.get('http://localhost:54071/api/product/get');
    }
}
