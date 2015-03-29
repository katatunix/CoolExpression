﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CELib.ExpressionImpl
{
	class SumExpression : Expression
	{
		public SumExpression(Expression e1, Expression e2)
		{
			m_e1 = e1;
			m_e2 = e2;
		}

		public override double interpret(string context)
		{
			return m_e1.interpret(context) + m_e2.interpret(context);
		}

		private Expression m_e1;
		private Expression m_e2;
	}
}
