using System;
using System.Collections.Generic;
using System.Text;

namespace appHotel.Model
{
    public class Hospedagem
    {
        Suite quarto;
        int Quantidade_adultos;


        public int QntAdultos
        {
            get => Quantidade_adultos;

            set
            {
                if (value == 0)
                    throw new Exception("Por favor, informe a quantidade de adultos:");
                Quantidade_adultos = value;
            }
        }
        public int QuantidadeCrianca { get; set; }

        public Suite Quarto
        {
            get => quarto;

            set
            {
                if (value == null)
                    throw new Exception("Por favor, selecione uma suíte:");
                quarto = value;
            }
        }

        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }

        public int Estadia
        {
            get
            {
                return DataCheckOut.Subtract(DataCheckIn).Days;
            }
        }
        public double ValorTotal
        {
            get => ((Quantidade_adultos * Quarto.ValorDiariaAdulto) + ((QuantidadeCrianca * Quarto.ValorDiariaCrianca)) + Estadia);

        }

    }
}
