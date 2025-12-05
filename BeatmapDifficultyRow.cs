// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

// ReSharper disable InconsistentNaming (intentionally matching database naming)

namespace osu.Server.OnlineDbGenerator
{
    public class BeatmapDifficultyRow
    {
        public int beatmap_id { get; set; }
        public int mode { get; set; }
        public int mods { get; set; }
        public double value { get; set; }
    }
}
