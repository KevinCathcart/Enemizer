﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemizerLibrary
{
    public class OverworldAreaConstants
    {
        public static string GetAreaName(int areaId)
        {
            string areaName;

            if (areaNames.TryGetValue(areaId, out areaName))
            {
                return areaName;
            }

            return null;
        }

        static Dictionary<int, string> areaNames = new Dictionary<int, string>()
        {
            // Light World (After Saving Zelda)
            { 0x000, "Lost Woods" },
            { 0x001, "Lost Woods (2)" },
            { 0x002, "Lumber Jack House" },
            { 0x003, "West Death Mountain" },
            { 0x004, "West Death Mountain (2)" },
            { 0x005, "East Death Mountain" },
            { 0x006, "East Death Mountain (2)" },
            { 0x007, "East Death Mountain Warp for Turtle Rock" },
            { 0x008, "Lost Woods (3?)" },
            { 0x009, "Lost Woods (4?)" },
            { 0x00A, "Entrance to Death Mountain" },
            { 0x00B, "West Death Mountain (3?)" },
            { 0x00C, "West Death Mountain (4?)" },
            { 0x00D, "East Death Mountain (3?)" },
            { 0x00E, "East Death Mountain (3?)" },
            { 0x00F, "Entrance to Zora's Domain" },
            { 0x010, "Path Between Kakariko Village and Lost Woods" },
            { 0x011, "Kakariko Village Fortune Teller" },
            { 0x012, "Pond Between Kakariko Village Fortune Teller and Sanctuary" },
            { 0x013, "Sanctuary" },
            { 0x014, "Graveyard" },
            { 0x015, "River Between Graveyard and Witch's Hut" },
            { 0x016, "Witch's Hut" },
            { 0x017, "East of Witch's Hut" },
            { 0x018, "Kakariko Village" },
            { 0x019, "Kakariko Village (2)" },
            { 0x01A, "Forest Between Kakariko Village and Hyrule Castle" },
            { 0x01B, "Hyrule Castle" },
            { 0x01C, "Hyrule Castle (2)" },
            { 0x01D, "Bridge Between Graveyard and Witch's Hut" },
            { 0x01E, "Eastern Palace" },
            { 0x01F, "Eastern Palace (2)" },
            { 0x020, "Kakariko Village (3?)" },
            { 0x021, "Kakariko Village (4?)" },
            { 0x022, "Smithy" },
            { 0x023, "Hyrule Castle (3?)" },
            { 0x024, "Hyrule Castle (4?)" },
            { 0x025, "Path Between Hyrule Castle and Eastern Palace}} (top)" },
            { 0x026, "Eastern Palace (3?)" },
            { 0x027, "Eastern Palace (4?)" },
            { 0x028, "Kakariko Village Maze Race" },
            { 0x029, "Kakariko Village Library" },
            { 0x02A, "Haunted Grove" },
            { 0x02B, "Forest Between Haunted Grove and Link's House" },
            { 0x02C, "Link's House" },
            { 0x02D, "Path Between Hyrule Castle and Eastern Palace}} (bottom)" },
            { 0x02E, "Caves South of Eastern Palace (left)" },
            { 0x02F, "Caves South of Eastern Palace (right)" },
            { 0x030, "Desert of Mystery" },
            { 0x031, "Desert of Mystery (2)" },
            { 0x032, "South of Haunted Grove" },
            { 0x033, "North-western Great Swamp" },
            { 0x034, "North-eastern Great Swamp" },
            { 0x035, "Lake Hylia" },
            { 0x036, "Lake Hylia (2)" },
            { 0x037, "Ice Cave" },
            { 0x038, "Desert of Mystery (3?)" },
            { 0x039, "Desert of Mystery (4?)" },
            { 0x03A, "Path Between Desert of Mystery and Great Swamp" },
            { 0x03B, "South-western Great Swamp" },
            { 0x03C, "South-eastern Great Swamp" },
            { 0x03D, "Lake Hylia (3?)" },
            { 0x03E, "Lake Hylia (4?)" },
            { 0x03F, "Path Between Lake Hylia and Ice Cave" },

            // Dark World
            { 0x040, "Skull Woods (DW)" },
            { 0x041, "Lumber Jack House (DW)" }, // double check, this should be Skull Woods....
            { 0x042, "Lumber Jack House (2) (DW)" },
            { 0x043, "West Death Mountain (DW)" },
            { 0x044, "East Death Mountain (DW)" }, // double check, this should be West DM....
            { 0x045, "East Death Mountain (2) (DW)" }, // double check, this should be East 1
            { 0x046, "??" }, // double check, this should be East (2)
            { 0x047, "Turtle Rock" },
            { 0x048, "Lost Woods (3?) (DW)" },
            { 0x049, "Lost Woods (4?) (DW)" },
            { 0x04A, "Bumper Cave Entrance (DW)" },
            { 0x04B, "West Death Mountain (3?) (DW)" },
            { 0x04C, "West Death Mountain (4?) (DW)" },
            { 0x04D, "East Death Mountain (3?) (DW)" },
            { 0x04E, "East Death Mountain (4?) (DW)" },
            { 0x04F, "Catfish (DW)" },
            { 0x050, "Path Between Village of Outcasts and Skull Woods (DW)" },
            { 0x051, "Village of Outcasts Fortune Teller (DW)" },
            { 0x052, "Pond Between Village of Outcasts Fortune Teller and Sanctuary (DW)" },
            { 0x053, "Sanctuary (DW)" },
            { 0x054, "Graveyard (DW)" },
            { 0x055, "River Between Graveyard and Witch's Hut (DW)" },
            { 0x056, "Witch's Hut (DW)" },
            { 0x057, "East of Witch's Hut (DW)" },
            { 0x058, "Village of Outcasts (DW)" },
            { 0x059, "Village of Outcasts (2) (DW)" },
            { 0x05A, "Forest Between Village of Outcasts and Pyramid (DW)" },
            { 0x05B, "Pyramid (DW)" },
            { 0x05C, "Pyramid (2) (DW)" },
            { 0x05D, "Broken Bridge Between Graveyard and Witch's Hut (DW)" },
            { 0x05E, "Palace of Darkness (DW)" },
            { 0x05F, "Palace of Darkness (2) (DW)" },
            { 0x060, "Village of Outcasts (3?) (DW)" },
            { 0x061, "Village of Outcasts (4?) (DW)" },
            { 0x062, "Smithy (DW)" },
            { 0x063, "Pyramid (3?) (DW)" },
            { 0x064, "Pyramid (4?) (DW)" },
            { 0x065, "Path Between Pyramid and Palace of Darkness}} (top) (DW)" },
            { 0x066, "Palace of Darkness (3?) (DW)" },
            { 0x067, "Palace of Darkness (4?) (DW)" },
            { 0x068, "Digging Game (DW)" },
            { 0x069, "Village of Outcasts Frog Smith (DW)" },
            { 0x06A, "Haunted Grove (DW)" },
            { 0x06B, "Forest Between Haunted Grove and Link's House (DW)" },
            { 0x06C, "Bomb Shop (Link's House) (DW)" },
            { 0x06D, "Path Between Pyramid and Palace of Darkness}} (bottom) (DW)" },
            { 0x06E, "Caves South of Palace of Darkness (left) (DW)" },
            { 0x06F, "Caves South of Palace of Darkness (right) (DW)" },
            { 0x070, "Misery Mire (DW)" },
            { 0x071, "South of Haunted Grove (DW)" },
            { 0x072, "South of Haunted Grove (DW) (Duplicate)" },
            { 0x073, "North-western Great Swamp (DW)" },
            { 0x074, "North-eastern Great Swamp (DW)" },
            { 0x075, "Lake Hylia (DW)" },
            { 0x076, "Ice Cave (DW)" },
            { 0x077, "Ice Cave (DW)" },
            { 0x078, "Misery Mire (3?) (DW)" },
            { 0x079, "Misery Mire (4?) (DW)" },
            { 0x07A, "Path Between Misery Mire and Great Swamp (DW)" },
            { 0x07B, "South-western Great Swamp (DW)" },
            { 0x07C, "South-eastern Great Swamp (DW)" },
            { 0x07D, "Lake Hylia (3?) (DW)" },
            { 0x07E, "Lake Hylia (4?) (DW)" },
            { 0x07F, "Path Between Lake Hylia and Ice Cave (DW)" },

            { 0x080, "Master Sword Glade / Under Bridge" },
            { 0x081, "Zora's Domain" },

            { 0x082, "??" },
            { 0x083, "??" },
            { 0x084, "??" },
            { 0x085, "??" },
            { 0x086, "??" },
            { 0x087, "??" },
            { 0x088, "??" },
            { 0x089, "??" },
            { 0x08A, "??" },
            { 0x08B, "??" },
            { 0x08C, "??" },
            { 0x08D, "??" },
            { 0x08E, "??" },
            { 0x08F, "??" },

            // after killing Aga (probably)
            // Light World (Post-Aga)
            { 0x090, "Lost Woods (Post-Aga)" },
            { 0x091, "Lost Woods (2) (Post-Aga)" },
            { 0x092, "Lumber Jack House (Post-Aga)" },
            { 0x093, "West Death Mountain (Post-Aga)" },
            { 0x094, "West Death Mountain (2) (Post-Aga)" },
            { 0x095, "East Death Mountain (Post-Aga)" },
            { 0x096, "East Death Mountain (2) (Post-Aga)" },
            { 0x097, "East Death Mountain Warp for Turtle Rock (Post-Aga)" },
            { 0x098, "Lost Woods (3?) (Post-Aga)" },
            { 0x099, "Lost Woods (4?) (Post-Aga)" },
            { 0x09A, "Entrance to Death Mountain (Post-Aga)" },
            { 0x09B, "West Death Mountain (3?) (Post-Aga)" },
            { 0x09C, "West Death Mountain (4?) (Post-Aga)" },
            { 0x09D, "East Death Mountain (3?) (Post-Aga)" },
            { 0x09E, "East Death Mountain (3?) (Post-Aga)" },
            { 0x09F, "Entrance to Zora's Domain (Post-Aga)" },
            { 0x0A0, "Path Between Kakariko Village and Lost Woods (Post-Aga)" },
            { 0x0A1, "Kakariko Village Fortune Teller (Post-Aga)" },
            { 0x0A2, "Pond Between Kakariko Village Fortune Teller and Sanctuary (Post-Aga)" },
            { 0x0A3, "Sanctuary (Post-Aga)" },
            { 0x0A4, "Graveyard (Post-Aga)" },
            { 0x0A5, "River Between Graveyard and Witch's Hut (Post-Aga)" },
            { 0x0A6, "Witch's Hut (Post-Aga)" },
            { 0x0A7, "East of Witch's Hut (Post-Aga)" },
            { 0x0A8, "Kakariko Village (Post-Aga)" },
            { 0x0A9, "Kakariko Village (2) (Post-Aga)" },
            { 0x0AA, "Forest Between Kakariko Village and Hyrule Castle (Post-Aga)" },
            { 0x0AB, "Hyrule Castle (Post-Aga)" },
            { 0x0AC, "Hyrule Castle (2) (Post-Aga)" },
            { 0x0AD, "Bridge Between Graveyard and Witch's Hut (Post-Aga)" },
            { 0x0AE, "Eastern Palace (Post-Aga)" },
            { 0x0AF, "Eastern Palace (2) (Post-Aga)" },
            { 0x0B0, "Kakariko Village (3?) (Post-Aga)" },
            { 0x0B1, "Kakariko Village (4?) (Post-Aga)" },
            { 0x0B2, "Smithy (Post-Aga)" },
            { 0x0B3, "Hyrule Castle (3?) (Post-Aga)" },
            { 0x0B4, "Hyrule Castle (4?) (Post-Aga)" },
            { 0x0B5, "Path Between Hyrule Castle and Eastern Palace}} (top) (Post-Aga)" },
            { 0x0B6, "Eastern Palace (3?) (Post-Aga)" },
            { 0x0B7, "Eastern Palace (4?) (Post-Aga)" },
            { 0x0B8, "Kakariko Village Maze Race (Post-Aga)" },
            { 0x0B9, "Kakariko Village Library (Post-Aga)" },
            { 0x0BA, "Haunted Grove (Post-Aga)" },
            { 0x0BB, "Forest Between Haunted Grove and Link's House (Post-Aga)" },
            { 0x0BC, "Link's House (Post-Aga)" },
            { 0x0BD, "Path Between Hyrule Castle and Eastern Palace}} (bottom) (Post-Aga)" },
            { 0x0BE, "Caves South of Eastern Palace (left) (Post-Aga)" },
            { 0x0BF, "Caves South of Eastern Palace (right) (Post-Aga)" },
            { 0x0C0, "Desert of Mystery (Post-Aga)" },
            { 0x0C1, "Desert of Mystery (2) (Post-Aga)" },
            { 0x0C2, "South of Haunted Grove (Post-Aga)" },
            { 0x0C3, "North-western Great Swamp (Post-Aga)" },
            { 0x0C4, "North-eastern Great Swamp (Post-Aga)" },
            { 0x0C5, "Lake Hylia (Post-Aga)" },
            //{ 0x0C6, "Lake Hylia (2) (Post-Aga)" },
            { 0x0C6, "Ice Cave (Post-Aga)??" }, // check, should be hylia (2)
            { 0x0C7, "Ice Cave (Post-Aga)" },
            //{ 0x0C8, "Desert of Mystery (3?) (Post-Aga)" },
            //{ 0x0C9, "Desert of Mystery (4?) (Post-Aga)" },
            { 0x0C8, "Path Between Desert of Mystery and Great Swamp (Post-Aga)??" }, // check, should be desert (3)
            { 0x0C9, "Path Between Desert of Mystery and Great Swamp (Post-Aga)??" }, // check, should be desert (4)
            { 0x0CA, "Path Between Desert of Mystery and Great Swamp (Post-Aga)" },
            { 0x0CB, "South-western Great Swamp (Post-Aga)" },
            { 0x0CC, "South-eastern Great Swamp (Post-Aga)" },
            //{ 0x0CD, "Lake Hylia (3?) (Post-Aga)" },
            //{ 0x0CE, "Lake Hylia (4?) (Post-Aga)" },
            { 0x0CD, "Path Between Lake Hylia and Ice Cave (Post-Aga)??" }, // check, should be lake (3)
            { 0x0CE, "Path Between Lake Hylia and Ice Cave (Post-Aga)??" }, // check, should be lake (4)
            { 0x0CF, "Path Between Lake Hylia and Ice Cave (Post-Aga)" },

            // Dark World (Post-Aga?)
            { 0x0D0, "Skull Woods (DW) (Post-Aga)" },
            { 0x0D1, "Lumber Jack House (DW) (Post-Aga)" }, // double check, this should be Skull Woods....
            { 0x0D2, "Lumber Jack House (2) (DW) (Post-Aga)" },
            { 0x0D3, "West Death Mountain (DW) (Post-Aga)" },
            { 0x0D4, "East Death Mountain (DW) (Post-Aga)" }, // double check, this should be West DM....
            { 0x0D5, "East Death Mountain (2) (DW) (Post-Aga)" }, // double check, this should be East 1
            { 0x0D6, "?? (Post-Aga)" }, // double check, this should be East (2)
            { 0x0D7, "Turtle Rock (Post-Aga)" },
            { 0x0D8, "Lost Woods (3?) (DW) (Post-Aga)" },
            { 0x0D9, "Lost Woods (4?) (DW) (Post-Aga)" },
            { 0x0DA, "Bumper Cave Entrance (DW) (Post-Aga)" },
            { 0x0DB, "West Death Mountain (3?) (DW) (Post-Aga)" },
            { 0x0DC, "West Death Mountain (4?) (DW) (Post-Aga)" },
            { 0x0DD, "East Death Mountain (3?) (DW) (Post-Aga)" },
            { 0x0DE, "East Death Mountain (4?) (DW) (Post-Aga)" },
            { 0x0DF, "Catfish (DW) (Post-Aga)" },
            { 0x0E0, "Path Between Village of Outcasts and Skull Woods (DW) (Post-Aga)" },
            { 0x0E1, "Village of Outcasts Fortune Teller (DW) (Post-Aga)" },
            { 0x0E2, "Pond Between Village of Outcasts Fortune Teller and Sanctuary (DW) (Post-Aga)" },
            { 0x0E3, "Sanctuary (DW) (Post-Aga)" },
            { 0x0E4, "Graveyard (DW) (Post-Aga)" },
            { 0x0E5, "River Between Graveyard and Witch's Hut (DW) (Post-Aga)" },
            { 0x0E6, "Witch's Hut (DW) (Post-Aga)" },
            { 0x0E7, "East of Witch's Hut (DW) (Post-Aga)" },
            { 0x0E8, "Village of Outcasts (DW) (Post-Aga)" },
            { 0x0E9, "Village of Outcasts (2) (DW) (Post-Aga)" },
            { 0x0EA, "Forest Between Village of Outcasts and Pyramid (DW) (Post-Aga)" },
            { 0x0EB, "Pyramid (DW) (Post-Aga)" },
            { 0x0EC, "Pyramid (2) (DW) (Post-Aga)" },
            { 0x0ED, "Broken Bridge Between Graveyard and Witch's Hut (DW) (Post-Aga)" },
            { 0x0EE, "Palace of Darkness (DW) (Post-Aga)" },
            { 0x0EF, "Palace of Darkness (2) (DW) (Post-Aga)" },
            { 0x0F0, "Village of Outcasts (3?) (DW) (Post-Aga)" },
            { 0x0F1, "Village of Outcasts (4?) (DW) (Post-Aga)" },
            { 0x0F2, "Smithy (DW) (Post-Aga)" },
            { 0x0F3, "Pyramid (3?) (DW) (Post-Aga)" },
            { 0x0F4, "Pyramid (4?) (DW) (Post-Aga)" },
            { 0x0F5, "Path Between Pyramid and Palace of Darkness}} (top) (DW) (Post-Aga)" },
            { 0x0F6, "Palace of Darkness (3?) (DW) (Post-Aga)" },
            { 0x0F7, "Palace of Darkness (4?) (DW) (Post-Aga)" },
            { 0x0F8, "Digging Game (DW) (Post-Aga)" },
            { 0x0F9, "Village of Outcasts Frog Smith (DW) (Post-Aga)" },
            { 0x0FA, "Haunted Grove (DW) (Post-Aga)" },
            { 0x0FB, "Forest Between Haunted Grove and Link's House (DW) (Post-Aga)" },
            { 0x0FC, "Bomb Shop (Link's House) (DW) (Post-Aga)" },
            { 0x0FD, "Path Between Pyramid and Palace of Darkness}} (bottom) (DW) (Post-Aga)" },
            { 0x0FE, "Caves South of Palace of Darkness (left) (DW) (Post-Aga)" },
            { 0x0FF, "Caves South of Palace of Darkness (right) (DW) (Post-Aga)" },
            { 0x100, "Misery Mire (DW) (Post-Aga)" },
            { 0x101, "South of Haunted Grove (DW) (Post-Aga)" },
            { 0x102, "South of Haunted Grove (DW) (Duplicate) (Post-Aga)" },
            { 0x103, "North-western Great Swamp (DW) (Post-Aga)" },
            { 0x104, "North-eastern Great Swamp (DW) (Post-Aga)" },
            { 0x105, "Lake Hylia (DW) (Post-Aga)" },
            { 0x106, "Ice Cave (DW) (Post-Aga)" },
            { 0x107, "Ice Cave (DW) (Post-Aga)" },
            { 0x108, "Misery Mire (3?) (DW) (Post-Aga)" },
            { 0x109, "Misery Mire (4?) (DW) (Post-Aga)" },
            { 0x10A, "Path Between Misery Mire and Great Swamp (DW) (Post-Aga)" },
            { 0x10B, "South-western Great Swamp (DW) (Post-Aga)" },
            { 0x10C, "South-eastern Great Swamp (DW) (Post-Aga)" },
            { 0x10D, "Lake Hylia (3?) (DW) (Post-Aga)" },
            { 0x10E, "Lake Hylia (4?) (DW) (Post-Aga)" },
            { 0x10F, "Path Between Lake Hylia and Ice Cave (DW) (Post-Aga)" },
            // these seem to be pointing to the same sprite data as pre-aga (same addresses)
            { 0x110, "Master Sword Glade / Under Bridge (Post-Aga)" },
            { 0x111, "Zora's Domain (Post-Aga)" },
        };
    }
}
