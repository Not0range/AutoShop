using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoShop
{
    abstract class EnumString
    {
        public abstract string GetString{ get; }
    }

    class Transmission : EnumString
    {
        public TransmissionEnum transmission;

        public Transmission(TransmissionEnum transmission)
        {
            this.transmission = transmission;
        }

        public override string GetString
        {
            get
            {
                switch (transmission)
                {
                    case TransmissionEnum.Automatic | TransmissionEnum.Manual:
                        return "Автоматическая или ручная коробка передач";
                    case TransmissionEnum.Automatic:
                        return "Автоматическая коробка передач";
                    case TransmissionEnum.Manual:
                        return "Ручная коробка передач";
                }
                return "";
            }
        }

        public static Transmission GetFromString(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                throw new ArgumentException(String.Format("Пустая строка недопустима", s));
            if ("автоматическая".StartsWith(s.ToLower()))
                return new Transmission(TransmissionEnum.Automatic);
            if ("ручная".StartsWith(s.ToLower()))
                return new Transmission(TransmissionEnum.Manual);
            throw new ArgumentException(String.Format("Строка \"{0}\" недопустима", s));
        }

        public enum TransmissionEnum
        {
            Automatic = 1,
            Manual = 2
        }
    }

    class State : EnumString
    {
        const decimal DEFAULT_DISTANCE = 50000;

        public StateEnum state;

        public decimal distance;

        public State(StateEnum state, decimal distance = 0)
        {
            this.state = state;
            this.distance = distance;
        }

        public override string GetString
        {
            get
            {
                switch (state)
                {
                    case StateEnum.New | StateEnum.Old:
                        return "Новый или поддержанный";
                    case StateEnum.New:
                        return "Новый";
                    case StateEnum.Old:
                        return String.Format("Подлержанный. Пробег: {0:F2}", distance);
                }
                return "";
            }
        }

        public static State GetFromValue(decimal value = 0)
        {
            if (value > 0)
                return new State(StateEnum.Old, value);
            else if(value == 0)
                return new State(StateEnum.New, 0);
            throw new ArgumentException(String.Format("Строка \"{0}\" недопустима", value));
        }

        public static State GetFromString(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                throw new ArgumentException(String.Format("Пустая строка недопустима", s));
            if ("новый".StartsWith(s.ToLower()))
                return new State(StateEnum.New);
            else if ("поддержанный".StartsWith(s.ToLower()))
                return new State(StateEnum.Old, DEFAULT_DISTANCE);
            throw new ArgumentException(String.Format("Строка \"{0}\" недопустима", s));
        }

        public enum StateEnum
        {
            Old = 1,
            New = 2
        }
    }
}
