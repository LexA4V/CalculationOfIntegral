namespace CalculationOfIntegral
{
    class TrapezoidMethod : BaseCalculateIntegral
    {
        private double[,] _matrixL;

        #region Свойства для доступа к параметрам интегрирования

        //не помню зачем умножать на 2 количество участков
        //может для большей точности

        public override int XNumberOfSections
        {
            get
            {
                return _xNumberOfSections;
            }

            set
            {
                _xNumberOfSections = 2 * value;
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
                _yNumberOfSections = 2 * value;
            }
        }

        #endregion

        public override double Calculate()
        {
            double h, k;

            if (!CheckValidator()) return double.NaN;

            h = (_oXFinish - _oXStart) / _xNumberOfSections;
            k = (_oYFinish - _oYStart) / _yNumberOfSections;

            _xNumberOfSections++; ///+1?
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
                    f[i, j] = 1 / (x[j] * y[i]);
                    S += _matrixL[i, j] * f[i, j];
                }
            }

            return h * k / 9 * S;
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
                    if (i == 0 || i == _yNumberOfSections - 1)
                    {
                        if (j == 0 || j == _xNumberOfSections - 1)
                            _matrixL[i, j] = 1;
                        else
                        {
                            if (j % 2 == 0)
                                _matrixL[i, j] = 2;
                            else if (j % 2 != 0)
                                _matrixL[i, j] = 4;
                        }
                    }
                    else if (i % 2 != 0)
                    {
                        if (j == 0 || j == _xNumberOfSections - 1)
                            _matrixL[i, j] = 4;
                        else
                        {
                            if (j % 2 == 0)
                                _matrixL[i, j] = 8;
                            else if (j % 2 != 0)
                                _matrixL[i, j] = 16;
                        }
                    }
                    else if (i % 2 == 0 && i != 0 && i != _yNumberOfSections - 1)
                    {
                        if (j == 0 || j == _xNumberOfSections - 1)
                            _matrixL[i, j] = 2;
                        else
                        {
                            if (j % 2 == 0)
                                _matrixL[i, j] = 4;
                            else if (j % 2 != 0)
                                _matrixL[i, j] = 8;
                        }
                    }
                }
        }
    }
}
