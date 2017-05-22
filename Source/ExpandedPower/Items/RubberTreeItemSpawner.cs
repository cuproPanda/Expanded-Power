﻿using Verse;

namespace ExpandedPower {

  internal class RubberTreeItemSpawner : ItemSpawner {

    public override void SpawnSetup(Map map, bool respawningAfterLoad) {
      base.SpawnSetup(map, respawningAfterLoad);
      SpawnRandomQuantity(ThingDef.Named("EXP_RubberWood"), 10, 20);
      Destroy();
    }
  }
}
