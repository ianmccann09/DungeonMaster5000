using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DandD.Enums;

namespace DandD.Interfaces
{
	interface IItem
	{
		int ItemId { get; set; }
		int Weight { get; set; }
		string Name { get; set; } 
		string Description { get; set; }
		ItemTypes Type { get; set; }
		
	}
}
