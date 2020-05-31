using UnityEngine;
using System;
using Simplex;

namespace Generation {
	public class CoastalMountainGenerator : SimpleBaseGenerator {

        public CoastalMountainGenerator(int? _seed = null) : base(_seed)
        {
            SeaLevel = 0.25f;
        }

		public override void Run() {
			Debug.Log("Seed is: "+seed);
			HeightOperations.AddSlope(map,1f,rand);
			map.Normalize();
			HeightOperations.AddNoise(map,0.1f,0.01f);
			HeightOperations.AddNoise(map,0.015f,0.05f);
			HeightOperations.AddNoise(map,0.005f,0.1f);
			map.Normalize();
			HeightOperations.ApplyPowerLevel(map, SeaLevel, 2f);
			map.Normalize();
			HeightOperations.Smooth(map, steps: 20, max_height: SeaLevel);
		}

	}
}
