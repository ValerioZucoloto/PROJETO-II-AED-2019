using System;
using System.Collections.Generic;

class Voo {
        public Piloto _piloto;
        public List<Passageiro> listaPassageiro = new List<Passageiro>();
        public Aviao _aviao;

        public Voo() {

        }

        public Voo (Piloto piloto, List <Passageiro> passageiros, Aviao aviao) {
                _piloto = piloto;
                listaPassageiro = passageiros;
                _aviao = aviao;        
        }
}