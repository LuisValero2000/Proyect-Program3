using System;

namespace ProyectoVSC{
    
    abstract class Ficha{
        private Forma forma;
        private bool colocado;

        public Forma getForma() {
            return this.forma;
        }

        public void setForma(Forma forma) {
            this.forma = forma;
        }

        public bool isColocado() {
            return this.colocado;
        }

        public void setColocado(bool colocado) {
            this.colocado = colocado;
        }

        public abstract bool estaColocado();
    }

    class FichaSudoku: Ficha{

        public FichaSudoku(){
            ConjuntoCuadrado conjuntoCuadrado = new ConjuntoCuadrado();
            conjuntoCuadrado.generarCuadro();
            this.setForma(conjuntoCuadrado);
        }

        public override bool estaColocado(){
            return this.isColocado();
        }


    }
}