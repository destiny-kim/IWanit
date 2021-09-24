using System;
using System.Collections;
using System.Collections.Generic;
using Realms;
using Module;

namespace Model
{
    public class Motive : RealmObject
    {
        public readonly Decimal LACK;
        private const double FULL = 10.0f;

        [PrimaryKey]
        public Guid ID
        {
            get; set;
        }

        public double Fun
        {
            get; set;
        }

        public double Energy
        {
            get; set;
        }

        public double Hunger
        {
            get; set;
        }

        public double Social
        {
            get; set;
        }

        public double Stress
        {
            get; set;
        }

        public Motive()
        {
        }

        public Motive(Guid id, Decimal intensity)
        {
            this.ID = id;
            this.Fun = FULL;
            this.Energy = FULL;
            this.Hunger = FULL;
            this.Social = FULL;
            this.Stress = FULL;

    public class MotiveValue
    {
        public readonly Motive motive;

        public PositiveDouble Fun
        {
            get; set;
        }

        public PositiveDouble Energy
        {
            get; set;
        }

        public PositiveDouble Hunger
        {
            get; set;
        }

        public PositiveDouble Social
        {
            get; set;
        }

        public PositiveDouble Stress
        {
            get; set;
        }

        public PositiveDouble Hygiene
        {
            get; set;
        }

        public PositiveDouble Urine
        {
            get; set;
        }

        public void UpdateMotiveRandomly()
        {
            try
            {
                var value = 
                    motive.random.NextDouble() * 
                    Converter<bool>.ConvertBoolToDouble
                    (
                        motive.random.NextDouble() > Constants.IncreaseOrDecreasePoint
                    ) * Constants.HandlingDigit;
                this.Fun += value;
            }
            catch (ArgumentException exception)
            {
            }

            try
            {
                var value = 
                    motive.random.NextDouble() *
                    Converter<bool>.ConvertBoolToDouble
                    (
                        motive.random.NextDouble() > Constants.IncreaseOrDecreasePoint
                    ) * Constants.HandlingDigit;
                this.Energy += value;
            }
            catch (ArgumentException exception)
            {
            }

            try
            {
                var value = 
                    motive.random.NextDouble() *
                    Converter<bool>.ConvertBoolToDouble
                    (
                        motive.random.NextDouble() > Constants.IncreaseOrDecreasePoint
                    ) * Constants.HandlingDigit;
                this.Hunger += value;
            }
            catch (ArgumentException exception)
            {
            }

            try
            {
                var value = 
                    motive.random.NextDouble() *
                    Converter<bool>.ConvertBoolToDouble
                    (
                        motive.random.NextDouble() > Constants.IncreaseOrDecreasePoint
                    ) * Constants.HandlingDigit;
                this.Social += value;
            }
            catch (ArgumentException exception)
            {
            }

            try
            {
                var value = 
                    motive.random.NextDouble() *
                    Converter<bool>.ConvertBoolToDouble
                    (
                        motive.random.NextDouble() > Constants.IncreaseOrDecreasePoint
                    ) * Constants.HandlingDigit;
                this.Stress += value;
            }
            catch (ArgumentException exception)
            {
            }

            try
            {
                var value = 
                    motive.random.NextDouble() *
                    Converter<bool>.ConvertBoolToDouble
                    (
                        motive.random.NextDouble() > Constants.IncreaseOrDecreasePoint
                    ) * Constants.HandlingDigit;
                this.Hygiene += value;
            }
            catch (ArgumentException exception)
            {
            }

            try
            {
                var value = 
                    motive.random.NextDouble() *
                    Converter<bool>.ConvertBoolToDouble
                    (
                        motive.random.NextDouble() > Constants.IncreaseOrDecreasePoint
                    ) * Constants.HandlingDigit;
                this.Urine += value;
            }
            catch (ArgumentException exception)
            {
            }
        }

        public bool DoesMotiveLack()
        {
            if
            (
                this.Fun <= this.motive.LackMotive
                || this.Energy <= this.motive.LackMotive
                || this.Hunger <= this.motive.LackMotive
                || this.Social <= this.motive.LackMotive
                || this.Hygiene <= this.motive.LackMotive
                || this.Urine <= this.motive.LackMotive
            )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public MotiveValue(Motive motive)
        {
            this.motive = motive;
            this.Fun = new PositiveDouble(motive.Fun);
            this.Energy = new PositiveDouble(motive.Energy);
            this.Hunger = new PositiveDouble(motive.Hunger);
            this.Social = new PositiveDouble(motive.Social);
            this.Stress = new PositiveDouble(motive.Stress);
            this.Hygiene = new PositiveDouble(motive.Hygiene);
            this.Urine = new PositiveDouble(motive.Urine);
        }
    }
}