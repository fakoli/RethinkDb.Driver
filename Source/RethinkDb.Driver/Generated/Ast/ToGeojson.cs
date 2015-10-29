












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

    public class ToGeojson : ReqlExpr {

    
    
    
/// <summary>
/// <para>Convert a ReQL geometry object to a [GeoJSON][] object.</para>
/// </summary>
/// <example><para>Example: Convert a ReQL geometry object to a GeoJSON object.</para>
/// <code>r.table(geo).get('sfo')('location').toGeojson.run(conn, callback);
/// // result passed to callback
/// {
///     'type': 'Point',
///     'coordinates': [ -122.423246, 37.779388 ]
/// }
/// </code></example>
        public ToGeojson (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Convert a ReQL geometry object to a [GeoJSON][] object.</para>
/// </summary>
/// <example><para>Example: Convert a ReQL geometry object to a GeoJSON object.</para>
/// <code>r.table(geo).get('sfo')('location').toGeojson.run(conn, callback);
/// // result passed to callback
/// {
///     'type': 'Point',
///     'coordinates': [ -122.423246, 37.779388 ]
/// }
/// </code></example>
        public ToGeojson (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Convert a ReQL geometry object to a [GeoJSON][] object.</para>
/// </summary>
/// <example><para>Example: Convert a ReQL geometry object to a GeoJSON object.</para>
/// <code>r.table(geo).get('sfo')('location').toGeojson.run(conn, callback);
/// // result passed to callback
/// {
///     'type': 'Point',
///     'coordinates': [ -122.423246, 37.779388 ]
/// }
/// </code></example>
        public ToGeojson (Arguments args, OptArgs optargs)
         : base(TermType.TO_GEOJSON, args, optargs) {
        }


    



    


    

    


    
    }
}
