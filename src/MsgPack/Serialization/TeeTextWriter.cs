﻿// <auto-generated>
//     This code was generated by a TeeTextWriter.tt.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using System.IO;
using System.Text;

namespace MsgPack.Serialization
{
	internal sealed class TeeTextWriter : TextWriter
	{
		private readonly TextWriter _main;
		private readonly TextWriter _sub;

		public override Encoding Encoding
		{
			get { return this._main.Encoding; }
		}

		public TeeTextWriter( TextWriter main, TextWriter sub )
		{
			this._main = main;
			this._sub = sub;
		}


		public override void Write( string value )
		{
			this._main.Write( value );
			this._sub.Write( value );
		}

		public override void Flush()
		{
			this._main.Flush();
			this._sub.Flush();
		}

#if !NETFX_CORE && !NETSTANDARD1_1 && !NETSTANDARD1_3
		public override void Close()
		{
			this._main.Close();
			this._sub.Close();
		}
#endif // !NETFX_CORE && !NETSTANDARD1_1 && !NETSTANDARD1_3

		public override void Write( char value )
		{
			this._main.Write( value );
			this._sub.Write( value );
		}

		public override void Write( char[] buffer )
		{
			this._main.Write( buffer );
			this._sub.Write( buffer );
		}

		public override void Write( char[] buffer, int index, int count )
		{
			this._main.Write( buffer, index, count );
			this._sub.Write( buffer, index, count );
		}

		public override void Write( bool value )
		{
			this._main.Write( value );
			this._sub.Write( value );
		}

		public override void Write( int value )
		{
			this._main.Write( value );
			this._sub.Write( value );
		}

		public override void Write( uint value )
		{
			this._main.Write( value );
			this._sub.Write( value );
		}

		public override void Write( long value )
		{
			this._main.Write( value );
			this._sub.Write( value );
		}

		public override void Write( ulong value )
		{
			this._main.Write( value );
			this._sub.Write( value );
		}

		public override void Write( float value )
		{
			this._main.Write( value );
			this._sub.Write( value );
		}

		public override void Write( double value )
		{
			this._main.Write( value );
			this._sub.Write( value );
		}

		public override void Write( decimal value )
		{
			this._main.Write( value );
			this._sub.Write( value );
		}

		public override void Write( object value )
		{
			this._main.Write( value );
			this._sub.Write( value );
		}

#if !NETSTANDARD1_1
		public override void Write( string format, object arg0 )
		{
			this._main.Write( format, arg0 );
			this._sub.Write( format, arg0 );
		}
#endif // !NETSTANDARD1_1

#if !NETSTANDARD1_1
		public override void Write( string format, object arg0, object arg1 )
		{
			this._main.Write( format, arg0, arg1 );
			this._sub.Write( format, arg0, arg1 );
		}
#endif // !NETSTANDARD1_1

#if !SILVERLIGHT && !NETSTANDARD1_1
		public override void Write( string format, object arg0, object arg1, object arg2 )
		{
			this._main.Write( format, arg0, arg1, arg2 );
			this._sub.Write( format, arg0, arg1, arg2 );
		}
#endif // !SILVERLIGHT && !NETSTANDARD1_1

		public override void Write( string format, object[] arg )
		{
			this._main.Write( format, arg );
			this._sub.Write( format, arg );
		}

		public override void WriteLine()
		{
			this._main.WriteLine();
			this._sub.WriteLine();
		}

		public override void WriteLine( char value )
		{
			this._main.WriteLine( value );
			this._sub.WriteLine( value );
		}

		public override void WriteLine( char[] buffer )
		{
			this._main.WriteLine( buffer );
			this._sub.WriteLine( buffer );
		}

		public override void WriteLine( char[] buffer, int index, int count )
		{
			this._main.WriteLine( buffer, index, count );
			this._sub.WriteLine( buffer, index, count );
		}

		public override void WriteLine( bool value )
		{
			this._main.WriteLine( value );
			this._sub.WriteLine( value );
		}

		public override void WriteLine( int value )
		{
			this._main.WriteLine( value );
			this._sub.WriteLine( value );
		}

		public override void WriteLine( uint value )
		{
			this._main.WriteLine( value );
			this._sub.WriteLine( value );
		}

		public override void WriteLine( long value )
		{
			this._main.WriteLine( value );
			this._sub.WriteLine( value );
		}

		public override void WriteLine( ulong value )
		{
			this._main.WriteLine( value );
			this._sub.WriteLine( value );
		}

		public override void WriteLine( float value )
		{
			this._main.WriteLine( value );
			this._sub.WriteLine( value );
		}

		public override void WriteLine( double value )
		{
			this._main.WriteLine( value );
			this._sub.WriteLine( value );
		}

		public override void WriteLine( decimal value )
		{
			this._main.WriteLine( value );
			this._sub.WriteLine( value );
		}

		public override void WriteLine( string value )
		{
			this._main.WriteLine( value );
			this._sub.WriteLine( value );
		}

		public override void WriteLine( object value )
		{
			this._main.WriteLine( value );
			this._sub.WriteLine( value );
		}

#if !NETSTANDARD1_1
		public override void WriteLine( string format, object arg0 )
		{
			this._main.WriteLine( format, arg0 );
			this._sub.WriteLine( format, arg0 );
		}
#endif // !NETSTANDARD1_1

#if !NETSTANDARD1_1
		public override void WriteLine( string format, object arg0, object arg1 )
		{
			this._main.WriteLine( format, arg0, arg1 );
			this._sub.WriteLine( format, arg0, arg1 );
		}
#endif // !NETSTANDARD1_1

#if !SILVERLIGHT && !NETSTANDARD1_1
		public override void WriteLine( string format, object arg0, object arg1, object arg2 )
		{
			this._main.WriteLine( format, arg0, arg1, arg2 );
			this._sub.WriteLine( format, arg0, arg1, arg2 );
		}
#endif // !SILVERLIGHT && !NETSTANDARD1_1

		public override void WriteLine( string format, object[] arg )
		{
			this._main.WriteLine( format, arg );
			this._sub.WriteLine( format, arg );
		}
	}
}