﻿using System;
using System.Collections.Generic;
using RimWorld;
using Verse;

namespace EdB.PrepareCarefully
{
	public class CustomRelationship
	{
		public CustomPawn source;
		public CustomPawn target;
		public PawnRelationDef def;
		public PawnRelationDef inverseDef;
		public bool removeable = true;

		public CustomRelationship()
		{
		}

		public CustomRelationship(PawnRelationDef def, CustomPawn source, CustomPawn target)
		{
			this.def = def;
			this.inverseDef = null;
			this.source = source;
			this.target = target;
			this.removeable = true;
		}

		public CustomRelationship(PawnRelationDef def, PawnRelationDef inverseDef, CustomPawn source, CustomPawn target)
		{
			this.def = def;
			this.inverseDef = inverseDef;
			this.source = source;
			this.target = target;
			this.removeable = true;
		}

		public CustomRelationship(PawnRelationDef def, PawnRelationDef inverseDef, CustomPawn source, CustomPawn target, bool removeable)
		{
			this.def = def;
			this.inverseDef = inverseDef;
			this.source = source;
			this.target = target;
			this.removeable = removeable;
		}

		public CustomRelationship(PawnRelationDef def, CustomPawn source, CustomPawn target, bool removeable)
		{
			this.def = def;
			this.source = source;
			this.target = target;
			this.removeable = removeable;
		}

		public override string ToString()
		{
			return (source != null ? source.Name.ToStringShort : "null")
				+ (target != null ? target.Name.ToStringShort : "null")
				+ (def != null ? def.defName : "null");
		}
	}
}

