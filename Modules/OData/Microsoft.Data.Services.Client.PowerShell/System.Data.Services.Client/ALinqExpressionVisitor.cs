namespace System.Data.Services.Client
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq.Expressions;

    internal abstract class ALinqExpressionVisitor
    {
        protected ALinqExpressionVisitor()
        {
        }

        internal virtual Expression Visit(Expression exp)
        {
            if (exp == null)
            {
                return exp;
            }
            switch (exp.NodeType)
            {
                case ExpressionType.Add:
                case ExpressionType.AddChecked:
                case ExpressionType.And:
                case ExpressionType.AndAlso:
                case ExpressionType.ArrayIndex:
                case ExpressionType.Coalesce:
                case ExpressionType.Divide:
                case ExpressionType.Equal:
                case ExpressionType.ExclusiveOr:
                case ExpressionType.GreaterThan:
                case ExpressionType.GreaterThanOrEqual:
                case ExpressionType.LeftShift:
                case ExpressionType.LessThan:
                case ExpressionType.LessThanOrEqual:
                case ExpressionType.Modulo:
                case ExpressionType.Multiply:
                case ExpressionType.MultiplyChecked:
                case ExpressionType.NotEqual:
                case ExpressionType.Or:
                case ExpressionType.OrElse:
                case ExpressionType.RightShift:
                case ExpressionType.Subtract:
                case ExpressionType.SubtractChecked:
                    return this.VisitBinary((BinaryExpression) exp);

                case ExpressionType.ArrayLength:
                case ExpressionType.Convert:
                case ExpressionType.ConvertChecked:
                case ExpressionType.Negate:
                case ExpressionType.UnaryPlus:
                case ExpressionType.NegateChecked:
                case ExpressionType.Not:
                case ExpressionType.Quote:
                case ExpressionType.TypeAs:
                    return this.VisitUnary((UnaryExpression) exp);

                case ExpressionType.Call:
                    return this.VisitMethodCall((MethodCallExpression) exp);

                case ExpressionType.Conditional:
                    return this.VisitConditional((ConditionalExpression) exp);

                case ExpressionType.Constant:
                    return this.VisitConstant((ConstantExpression) exp);

                case ExpressionType.Invoke:
                    return this.VisitInvocation((InvocationExpression) exp);

                case ExpressionType.Lambda:
                    return this.VisitLambda((LambdaExpression) exp);

                case ExpressionType.ListInit:
                    return this.VisitListInit((ListInitExpression) exp);

                case ExpressionType.MemberAccess:
                    return this.VisitMemberAccess((MemberExpression) exp);

                case ExpressionType.MemberInit:
                    return this.VisitMemberInit((MemberInitExpression) exp);

                case ExpressionType.New:
                    return this.VisitNew((NewExpression) exp);

                case ExpressionType.NewArrayInit:
                case ExpressionType.NewArrayBounds:
                    return this.VisitNewArray((NewArrayExpression) exp);

                case ExpressionType.Parameter:
                    return this.VisitParameter((ParameterExpression) exp);

                case ExpressionType.TypeIs:
                    return this.VisitTypeIs((TypeBinaryExpression) exp);
            }
            throw new NotSupportedException(System.Data.Services.Client.Strings.ALinq_UnsupportedExpression(exp.NodeType.ToString()));
        }

        internal virtual Expression VisitBinary(BinaryExpression b)
        {
            Expression left = this.Visit(b.Left);
            Expression right = this.Visit(b.Right);
            Expression expression3 = this.Visit(b.Conversion);
            if (((left == b.Left) && (right == b.Right)) && (expression3 == b.Conversion))
            {
                return b;
            }
            if ((b.NodeType == ExpressionType.Coalesce) && (b.Conversion != null))
            {
                return Expression.Coalesce(left, right, expression3 as LambdaExpression);
            }
            return Expression.MakeBinary(b.NodeType, left, right, b.IsLiftedToNull, b.Method);
        }

        internal virtual MemberBinding VisitBinding(MemberBinding binding)
        {
            switch (binding.BindingType)
            {
                case MemberBindingType.Assignment:
                    return this.VisitMemberAssignment((MemberAssignment) binding);

                case MemberBindingType.MemberBinding:
                    return this.VisitMemberMemberBinding((MemberMemberBinding) binding);

                case MemberBindingType.ListBinding:
                    return this.VisitMemberListBinding((MemberListBinding) binding);
            }
            throw new NotSupportedException(System.Data.Services.Client.Strings.ALinq_UnsupportedExpression(binding.BindingType.ToString()));
        }

        internal virtual IEnumerable<MemberBinding> VisitBindingList(ReadOnlyCollection<MemberBinding> original)
        {
            List<MemberBinding> list = null;
            int num = 0;
            int count = original.Count;
            while (num < count)
            {
                MemberBinding item = this.VisitBinding(original[num]);
                if (list != null)
                {
                    list.Add(item);
                }
                else if (item != original[num])
                {
                    list = new List<MemberBinding>(count);
                    for (int i = 0; i < num; i++)
                    {
                        list.Add(original[i]);
                    }
                    list.Add(item);
                }
                num++;
            }
            if (list != null)
            {
                return list;
            }
            return original;
        }

        internal virtual Expression VisitConditional(ConditionalExpression c)
        {
            Expression test = this.Visit(c.Test);
            Expression ifTrue = this.Visit(c.IfTrue);
            Expression ifFalse = this.Visit(c.IfFalse);
            if (((test != c.Test) || (ifTrue != c.IfTrue)) || (ifFalse != c.IfFalse))
            {
                return Expression.Condition(test, ifTrue, ifFalse, ifTrue.Type.IsAssignableFrom(ifFalse.Type) ? ifTrue.Type : ifFalse.Type);
            }
            return c;
        }

        internal virtual Expression VisitConstant(ConstantExpression c)
        {
            return c;
        }

        internal virtual ElementInit VisitElementInitializer(ElementInit initializer)
        {
            ReadOnlyCollection<Expression> arguments = this.VisitExpressionList(initializer.Arguments);
            if (arguments == initializer.Arguments)
            {
                return initializer;
            }
            return Expression.ElementInit(initializer.AddMethod, arguments);
        }

        internal virtual IEnumerable<ElementInit> VisitElementInitializerList(ReadOnlyCollection<ElementInit> original)
        {
            List<ElementInit> list = null;
            int num = 0;
            int count = original.Count;
            while (num < count)
            {
                ElementInit item = this.VisitElementInitializer(original[num]);
                if (list != null)
                {
                    list.Add(item);
                }
                else if (item != original[num])
                {
                    list = new List<ElementInit>(count);
                    for (int i = 0; i < num; i++)
                    {
                        list.Add(original[i]);
                    }
                    list.Add(item);
                }
                num++;
            }
            if (list != null)
            {
                return list;
            }
            return original;
        }

        internal virtual ReadOnlyCollection<Expression> VisitExpressionList(ReadOnlyCollection<Expression> original)
        {
            List<Expression> list = null;
            int num = 0;
            int count = original.Count;
            while (num < count)
            {
                Expression item = this.Visit(original[num]);
                if (list != null)
                {
                    list.Add(item);
                }
                else if (item != original[num])
                {
                    list = new List<Expression>(count);
                    for (int i = 0; i < num; i++)
                    {
                        list.Add(original[i]);
                    }
                    list.Add(item);
                }
                num++;
            }
            if (list != null)
            {
                return new ReadOnlyCollection<Expression>(list);
            }
            return original;
        }

        internal virtual Expression VisitInvocation(InvocationExpression iv)
        {
            IEnumerable<Expression> arguments = this.VisitExpressionList(iv.Arguments);
            Expression expression = this.Visit(iv.Expression);
            if ((arguments == iv.Arguments) && (expression == iv.Expression))
            {
                return iv;
            }
            return Expression.Invoke(expression, arguments);
        }

        internal virtual Expression VisitLambda(LambdaExpression lambda)
        {
            Expression body = this.Visit(lambda.Body);
            if (body != lambda.Body)
            {
                return Expression.Lambda(lambda.Type, body, lambda.Parameters);
            }
            return lambda;
        }

        internal virtual Expression VisitListInit(ListInitExpression init)
        {
            NewExpression newExpression = this.VisitNew(init.NewExpression);
            IEnumerable<ElementInit> initializers = this.VisitElementInitializerList(init.Initializers);
            if ((newExpression == init.NewExpression) && (initializers == init.Initializers))
            {
                return init;
            }
            return Expression.ListInit(newExpression, initializers);
        }

        internal virtual Expression VisitMemberAccess(MemberExpression m)
        {
            Expression expression = this.Visit(m.Expression);
            if (expression == m.Expression)
            {
                return m;
            }
            return Expression.MakeMemberAccess(expression, m.Member);
        }

        internal virtual MemberAssignment VisitMemberAssignment(MemberAssignment assignment)
        {
            Expression expression = this.Visit(assignment.Expression);
            if (expression == assignment.Expression)
            {
                return assignment;
            }
            return Expression.Bind(assignment.Member, expression);
        }

        internal virtual Expression VisitMemberInit(MemberInitExpression init)
        {
            NewExpression newExpression = this.VisitNew(init.NewExpression);
            IEnumerable<MemberBinding> bindings = this.VisitBindingList(init.Bindings);
            if ((newExpression == init.NewExpression) && (bindings == init.Bindings))
            {
                return init;
            }
            return Expression.MemberInit(newExpression, bindings);
        }

        internal virtual MemberListBinding VisitMemberListBinding(MemberListBinding binding)
        {
            IEnumerable<ElementInit> initializers = this.VisitElementInitializerList(binding.Initializers);
            if (initializers == binding.Initializers)
            {
                return binding;
            }
            return Expression.ListBind(binding.Member, initializers);
        }

        internal virtual MemberMemberBinding VisitMemberMemberBinding(MemberMemberBinding binding)
        {
            IEnumerable<MemberBinding> bindings = this.VisitBindingList(binding.Bindings);
            if (bindings == binding.Bindings)
            {
                return binding;
            }
            return Expression.MemberBind(binding.Member, bindings);
        }

        internal virtual Expression VisitMethodCall(MethodCallExpression m)
        {
            Expression instance = this.Visit(m.Object);
            IEnumerable<Expression> arguments = this.VisitExpressionList(m.Arguments);
            if ((instance == m.Object) && (arguments == m.Arguments))
            {
                return m;
            }
            return Expression.Call(instance, m.Method, arguments);
        }

        internal virtual NewExpression VisitNew(NewExpression nex)
        {
            IEnumerable<Expression> arguments = this.VisitExpressionList(nex.Arguments);
            if (arguments == nex.Arguments)
            {
                return nex;
            }
            if (nex.Members == null)
            {
                return Expression.New(nex.Constructor, arguments);
            }
            return Expression.New(nex.Constructor, arguments, nex.Members);
        }

        internal virtual Expression VisitNewArray(NewArrayExpression na)
        {
            IEnumerable<Expression> bounds = this.VisitExpressionList(na.Expressions);
            if (bounds == na.Expressions)
            {
                return na;
            }
            if (na.NodeType != ExpressionType.NewArrayInit)
            {
                return Expression.NewArrayBounds(na.Type.GetElementType(), bounds);
            }
            return Expression.NewArrayInit(na.Type.GetElementType(), bounds);
        }

        internal virtual Expression VisitParameter(ParameterExpression p)
        {
            return p;
        }

        internal virtual Expression VisitTypeIs(TypeBinaryExpression b)
        {
            Expression expression = this.Visit(b.Expression);
            if (expression == b.Expression)
            {
                return b;
            }
            return Expression.TypeIs(expression, b.TypeOperand);
        }

        internal virtual Expression VisitUnary(UnaryExpression u)
        {
            Expression operand = this.Visit(u.Operand);
            if (operand == u.Operand)
            {
                return u;
            }
            return Expression.MakeUnary(u.NodeType, operand, u.Type, u.Method);
        }
    }
}

