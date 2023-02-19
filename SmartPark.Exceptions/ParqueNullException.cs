using System;
namespace SmartPark.Exceptions
{
	public class ParqueNullException : Exception
	{
		public ParqueNullException(string source)
		{
			this.Source = source;
		}

        public override string Message => "This parque is null";
    }
}

