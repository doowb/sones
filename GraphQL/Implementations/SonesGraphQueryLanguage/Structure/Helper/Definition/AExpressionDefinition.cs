/*
* sones GraphDB - Community Edition - http://www.sones.com
* Copyright (C) 2007-2011 sones GmbH
*
* This file is part of sones GraphDB Community Edition.
*
* sones GraphDB is free software: you can redistribute it and/or modify
* it under the terms of the GNU Affero General Public License as published by
* the Free Software Foundation, version 3 of the License.
* 
* sones GraphDB is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
* GNU Affero General Public License for more details.
*
* You should have received a copy of the GNU Affero General Public License
* along with sones GraphDB. If not, see <http://www.gnu.org/licenses/>.
* 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sones.GraphDB.Expression;
using sones.GraphQL.ErrorHandling;

namespace sones.GraphQL.GQL.Structure.Nodes.Expressions
{
    public abstract class AExpressionDefinition
    {
        protected BinaryOperator GetOperatorBySymbol(string myOperatorSymbol)
        {
            switch (myOperatorSymbol.ToUpper())
            {
                case "=":
                    return BinaryOperator.Equals;

                case ">":
                    return BinaryOperator.GreaterThan;

                case "<":
                    return BinaryOperator.LessThan;

                case ">=":
                    return BinaryOperator.GreaterOrEqualsThan;

                case "<=":
                    return BinaryOperator.LessOrEqualsThan;

                case "!=":
                    return BinaryOperator.NotEquals;

                case "AND":
                    return BinaryOperator.AND;

                case "OR":
                    return BinaryOperator.OR;

                case "INRANGE":
                    return BinaryOperator.InRange;

                case "LIKE":
                    return BinaryOperator.Like;

                default:

                    throw new NotImplementedQLException(String.Format("The operator {0} is not yet implemented.", myOperatorSymbol));
            }
        }
    }
}
