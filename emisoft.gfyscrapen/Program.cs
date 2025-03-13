using System;
using System.Threading;

using EmiSoft;

namespace EmiSoft
{
    class GfyScrapen
    {
	public static void Main(string[] args)
	{
	    // flow
	    // load config.json, read port & key
	    // load sites/ recurs. httpserver reads

	    // webserver sends request to current http. to prevent hanging,
	    // return a response, then create new thread w/ selenium & scrape
	    // then, after results, encode json then send back to webserver w/
	    // key to prevent hanging
	    
	    Console.WriteLine("starting http server");

            HttpServer.start();
        }
    }
}
