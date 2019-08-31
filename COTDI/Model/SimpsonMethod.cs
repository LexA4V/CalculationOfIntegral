namespace CalculationOfIntegral
{
    class SimpsonMethod : BaseCalculateIntegral
    {
        private double[,] _matrixL;

        #region Свойства для доступа к параметрам интегрирования

        //не помню зачем умножать на 4 количество участков
        //может для большей точности

        public override int XNumberOfSections
        {
            get
            {
                return _xNumberOfSections;
            }

            set
            {
                _xNumberOfSections = 4 * value;
            }
        }

        public override int YNumberOfSections
        {
            get
            {
                return _yNumberOfSections;
            }

            set
            {
                _yNumberOfSections = 4 * value;
            }
        }

        #endregion

        public override double Calculate()
        {
            double h, k;


            if (!CheckValidator()) return double.NaN;

            h = (_oXFinish - _oXStart) / _xNumberOfSections;
            k = (_oYFinish - _oYStart) / _yNumberOfSections;

            _xNumberOfSections++;
            _yNumberOfSections++;

            double[] x = new double[_xNumberOfSections];
            double[] y = new double[_yNumberOfSections];

            //Координаты узлов
            for (int i = 0; i < _xNumberOfSections; i++)
                x[i] = _oXStart + i * h;
            for (int j = 0; j < _yNumberOfSections; j++)
                y[j] = _oYStart + j * k;

            //обновляем матрицу если требуется
            MatrixL();

            //кубатурная формула трапеций
            double S = 0.0;
            double[,] f = new double[_yNumberOfSections, _xNumberOfSections];
            for (int i = 0; i < _yNumberOfSections; i++)
            {
                for (int j = 0; j < _xNumberOfSections; j++)
                {
                    f[i, j] = 1 / (x[j] * y[i]); //интеграл?
                    S += _matrixL[i, j] * f[i, j];
                }
            }

            return h * k / 6 * S;
        }

        private void MatrixL()
        {
            if (_matrixL != null && _yNumberOfSections == _matrixL.GetLength(0) && _xNumberOfSections == _matrixL.GetLength(1))
                return;

            //матрица л коэффициентов
            _matrixL = new double[_yNumberOfSections, _xNumberOfSections];

            for (int i = 0; i < _yNumberOfSections; i++)
                for (int j = 0; j < _xNumberOfSections; j++)
                {
                    if (i == 0)
                    {
                        if (j == 0)
                            _matrixL[i, j] = 2;
                        else if (j == _xNumberOfSections - 1)
                            _matrixL[i, j] = 1;
                        else
                            _matrixL[i, j] = 3;
                    }
                    else if (i == _yNumberOfSections - 1)
                    {
                        if (j == _xNumberOfSections - 1)
                            _matrixL[i, j] = 2;
                        else if (j == 0)
                            _matrixL[i, j] = 1;
                        else
                            _matrixL[i, j] = 3;
                    }
                    else
                    {
                        if (j == 0 || j == _xNumberOfSections - 1)
                            _matrixL[i, j] = 3;
                        else
                            _matrixL[i, j] = 6;
                    }
                }
        }
    }
}
