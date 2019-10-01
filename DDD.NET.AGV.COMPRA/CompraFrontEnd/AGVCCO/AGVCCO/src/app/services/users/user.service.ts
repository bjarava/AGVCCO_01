import { Injectable } from '@angular/core';
import { HttpClient, HttpHandler } from '@angular/common/http'; 

@Injectable({providedIn: 'root'})
export class UserService {
    constructor(private http: HttpClient) {
        console.log('Servicio listo User');
        this.GetUser();
    }
    /**
     * Obtener usuarios
     */
    GetUser() {
        return this.http.get('http://localhost:54071/api/user/get');
    }
}
