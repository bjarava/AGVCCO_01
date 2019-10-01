import { DecimalPipe } from '@angular/common';

/*Entidad de  productos*/
export class Product {
    /**Identificador del producto */
    public Proide: number;
    /**Nombre del producto */
    public Pronom: string;
    /**Precio del producto */
    public Propre: number;
    /**Fecha de cracion del producto */
    public Profcr: Date;
    /**Cantidad */
    public Procan: number;
    /**Referencia */
    public Proref: string;

}
