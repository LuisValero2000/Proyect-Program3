using System;
using System.Collections.Generic; 

namespace ProyectoVSC{

    abstract class Forma{}

    class ConjuntoCuadrado: Forma{
        private Cuadro principal;
        private int tamano;

        public int getTamano() {
            return this.tamano;
        }

        public void setTamano(int tamano) {
            this.tamano = tamano;
        }


        public Cuadro getPrincipal() {
            return this.principal;
        }

        public void setPrincipal(Cuadro principal) {
            this.principal = principal;
        }

        public void generarCuadro(){
            this.tamano = 0;
            Random r = new Random();
            int aux = r.Next(3+(this.tamano));
            while(aux < 4){
                if(this.principal == null){
                    Cuadro cuadro = new Cuadro();
                    cuadro.setIndice(this.tamano);
                    this.principal = cuadro;                    
                }else{
                    Cuadro cuadro = new Cuadro();
                    this.tamano += 1;
                    cuadro.setIndice(this.tamano);
                    this.principal.combinar(cuadro);
                }
                if (this.tamano == 4){
                    aux = 5;
                }else{
                    aux = r.Next(3+(this.tamano));
                }
            }
        }  
    }
}