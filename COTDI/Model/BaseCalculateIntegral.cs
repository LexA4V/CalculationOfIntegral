namespace CalculationOfIntegral
{
    public abstract class BaseCalculateIntegral : ICalculateIntegral
    {
        //координаты начала и конца отрезка интегрирования [a; A]
        protected double _oXStart, _oXFinish;
        //количество пар участков разбиения отрезка [a; A]
        protected int _xNumberOfSections;

        //координаты начала и конца отрезка интегрирования [b; B]
        protected double _oYStart, _oYFinish;
        //количество пар участков разбиения отрезка [b; B] 
        protected int _yNumberOfSections;

        #region Свойства для доступа к параметрам интегрирования

        public virtual double OXStart
        {
            get
            {
                return _oXStart;
            }

            set
            {
                _oXStart = value;
            }
        }

        public virtual double OXFinish
        {
            get
            {
                return _oXFinish;
            }

            set
            {
                _oXFinish = value;
            }
        }

        public virtual int XNumberOfSections
        {
            get
            {
                return _xNumberOfSections;
            }

            set
            {
                _xNumberOfSections = value;
            }
        }

        public virtual double OYStart
        {
            get
            {
                return _oYStart;
            }

            set
            {
                _oYStart = value;
            }
        }

        public virtual double OYFinish
        {
            get
            {
                return _oYFinish;
            }

            set
            {
                _oYFinish = value;
            }
        }

        public virtual int YNumberOfSections
        {
            get
            {
                return _yNumberOfSections;
            }

            set
            {
                _yNumberOfSections = value;
            }
        }

        #endregion


        public abstract double Calculate();

        public bool CheckValidator()
        {
            if (_xNumberOfSections <= 0 || _yNumberOfSections <= 0) return false;

            if (_oXStart > _oXFinish || (_oXStart == _oXFinish && _oXStart == 0)) return false;

            if (_oYStart > _oYFinish || (_oYStart == _oYFinish && _oYStart == 0)) return false;

            return true;
        }
    }
}
