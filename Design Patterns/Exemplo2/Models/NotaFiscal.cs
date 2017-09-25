﻿using System;

namespace Exemplo2.Models
{
    public class NotaFiscal
    {
        public string Cliente { get; private set; }
        public double Valor { get; private set; }
        public DateTime Data { get; private set; }

        public NotaFiscal(string cliente, double valor, DateTime data)
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this.Data = data;
        }
    }
}
