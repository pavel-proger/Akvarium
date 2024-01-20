/*
 * Created by SharpDevelop.
 * User: HP8440P
 * Date: 20.01.2024
 * Time: 12:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SmartStorage
{
	class Program
	{
		public static void Main(string[] args)
		{
			Switch AkvariumState
                         Case 0 // Фильтр загрязнился;
                         Filter = false ;
                         pumpState = true ;
                         If( pumpState = true ) AkvariumState = 1 ;
                         If( tempAkvarium< X ) AkvariumState = 2 ;
                         If( tempAkvarium> X ) AkvariumState = 3 ;
                         If( waterLevel < Z ) AkvariumState = 4 ;
                         If( waterLevel > Z ) AkvariumState = 5 ;
                         Case 1 // Насос перестал циркулировать;
                         If( Filter = true ) AkvariumState = 0 ;
                         If( tempAkvarium< X ) AkvariumState = 2 ;
                         If( tempAkvarium> X ) AkvariumState = 3 ;
                         If( waterLevel < Z ) AkvariumState = 4 ;
                         If( waterLevel > Z ) AkvariumState = 5 ;т
                         pumpState = false ;
                         Case 2 // Температура упала включить нагрев;
                         If( Filter = true ) AkvariumState = 0 ;
                         If( pumpState = true ) AkvariumState = 1 ;
                         If( tempAkvarium> X ) AkvariumState = 3 ;
                         If( waterLevel < Z ) AkvariumState = 4 ;
                         If( waterLevel > Z ) AkvariumState = 5 ;
                         heaterOn = true ;
                         Case 3 // Температура повысилась выключить нагрев;
                         If( Filter = true ) AkvariumState = 0 ;
                         If( pumpState = true ) AkvariumState = 1 ;
                         If( tempAkvarium< X ) AkvariumState = 2 ;
                         If( waterLevel < Z ) AkvariumState = 4 ;
                         If( waterLevel > Z ) AkvariumState = 5 ;
                         heaterOn = false ;
                         Case 4 // Донабор воды из вне
                         If( Filter = true ) AkvariumState = 0 ;
                         If( pumpState = true ) AkvariumState = 1 ;
                         If( tempAkvarium< X ) AkvariumState = 2 ;
                         If( tempAkvarium> X ) AkvariumState = 3 ;
                         If( waterLevel > Z ) AkvariumState = 5 ;
                         valveOn = true ;
                         Case 5 // Слив воды
                         If( Filter = true ) AkvariumState = 0 ;
                         If( pumpState = true ) AkvariumState = 1 ;
                         If( tempAkvarium< X ) AkvariumState = 2 ;
                         If( tempAkvarium> X ) AkvariumState = 3 ;
                         If( waterLevel < Z ) AkvariumState = 4 ;
                         valveOn = false ;

				}	
			}
			
			
			}
			/*
			  * 
			  * 
			  * 
			  * Данный код педоставлен в ознакомительных целях, для конкетного внедрения на определенной системе удет нужна доработка под потребноси этой системы.
			  * This code is provided in acquittal purposes, for a particular implementation on a certain system, refinement will be needed for the need of this system.
			  * 
			  * 
			  * 
			  * */
		}
	}
}