












//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public class DayOfWeek : ReqlExpr {

    
    
    
/// <summary>
/// <para>Return the day of week of a time object as a number between 1 and 7 (following ISO 8601 standard). For your convenience, the terms r.monday, r.tuesday etc. are defined and map to the appropriate integer.</para>
/// </summary>
/// <example><para>Example: Return today's day of week.</para>
/// <code>r.now().dayOfWeek().run(conn, callback)
/// </code></example>
        public DayOfWeek (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Return the day of week of a time object as a number between 1 and 7 (following ISO 8601 standard). For your convenience, the terms r.monday, r.tuesday etc. are defined and map to the appropriate integer.</para>
/// </summary>
/// <example><para>Example: Return today's day of week.</para>
/// <code>r.now().dayOfWeek().run(conn, callback)
/// </code></example>
        public DayOfWeek (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Return the day of week of a time object as a number between 1 and 7 (following ISO 8601 standard). For your convenience, the terms r.monday, r.tuesday etc. are defined and map to the appropriate integer.</para>
/// </summary>
/// <example><para>Example: Return today's day of week.</para>
/// <code>r.now().dayOfWeek().run(conn, callback)
/// </code></example>
        public DayOfWeek (Arguments args, OptArgs optargs)
         : base(TermType.DAY_OF_WEEK, args, optargs) {
        }


    



    


    

    


    
    }
}
