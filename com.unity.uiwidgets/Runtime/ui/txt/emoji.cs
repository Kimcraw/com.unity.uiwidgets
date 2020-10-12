using System;
using System.Collections.Generic;
using Unity.UIWidgets.foundation;
using UnityEngine;

namespace Unity.UIWidgets.uiOld{

    public class EmojiResourceConfiguration {
        public readonly string spriteSheetAssetName;
        public readonly Dictionary<int, int> emojiLookupTable;
        public readonly int spriteSheetNumberOfRows;
        public readonly int spriteSheetNumberOfColumns;

        public EmojiResourceConfiguration(
            string spriteSheetAssetName,
            List<int> emojiCodes,
            int spriteSheetNumberOfRows,
            int spriteSheetNumberOfColumns
        ) {
            D.assert(spriteSheetAssetName != null);
            D.assert(emojiCodes != null && emojiCodes.isNotEmpty());
            D.assert(spriteSheetNumberOfColumns > 0);
            D.assert(spriteSheetNumberOfRows > 0);
            D.assert(emojiCodes.Count <= spriteSheetNumberOfColumns * spriteSheetNumberOfRows);
            this.spriteSheetAssetName = spriteSheetAssetName;
            emojiLookupTable = new Dictionary<int, int>();
            for (int i = 0; i < emojiCodes.Count; i++) {
                emojiLookupTable[emojiCodes[i]] = i;
            }
            this.spriteSheetNumberOfRows = spriteSheetNumberOfRows;
            this.spriteSheetNumberOfColumns = spriteSheetNumberOfColumns;
        }
    }
    
    public class EmojiUtils {
        public static readonly EmojiResourceConfiguration googleEmojiConfiguration = new EmojiResourceConfiguration (
            "images/EmojiGoogle",
            emojiCodes: new List<int> {
                0x1f004, 0x1f0cf, 0x1f170, 0x1f171, 0x1f17e, 0x1f17f, 0x1f18e,
                0x1f191, 0x1f192, 0x1f193, 0x1f194, 0x1f195, 0x1f196, 0x1f197,
                0x1f198, 0x1f199, 0x1f19a, 0x1f1e6, 0x1f1e7, 0x1f1e8, 0x1f1e9,
                0x1f1ea, 0x1f1eb, 0x1f1ec, 0x1f1ed, 0x1f1ee, 0x1f1ef, 0x1f1f0,
                0x1f1f1, 0x1f1f2, 0x1f1f3, 0x1f1f4, 0x1f1f5, 0x1f1f6, 0x1f1f7,
                0x1f1f8, 0x1f1f9, 0x1f1fa, 0x1f1fb, 0x1f1fc, 0x1f1fd, 0x1f1fe,
                0x1f1ff, 0x1f201, 0x1f202, 0x1f21a, 0x1f22f, 0x1f232, 0x1f233,
                0x1f234, 0x1f235, 0x1f236, 0x1f237, 0x1f238, 0x1f239, 0x1f23a,
                0x1f250, 0x1f251, 0x1f300, 0x1f301, 0x1f302, 0x1f303, 0x1f304,
                0x1f305, 0x1f306, 0x1f307, 0x1f308, 0x1f309, 0x1f30a, 0x1f30b,
                0x1f30c, 0x1f30d, 0x1f30e, 0x1f30f, 0x1f310, 0x1f311, 0x1f312,
                0x1f313, 0x1f314, 0x1f315, 0x1f316, 0x1f317, 0x1f318, 0x1f319,
                0x1f31a, 0x1f31b, 0x1f31c, 0x1f31d, 0x1f31e, 0x1f31f, 0x1f320,
                0x1f321, 0x1f324, 0x1f325, 0x1f326, 0x1f327, 0x1f328, 0x1f329,
                0x1f32a, 0x1f32b, 0x1f32c, 0x1f32d, 0x1f32e, 0x1f32f, 0x1f330,
                0x1f331, 0x1f332, 0x1f333, 0x1f334, 0x1f335, 0x1f336, 0x1f337,
                0x1f338, 0x1f339, 0x1f33a, 0x1f33b, 0x1f33c, 0x1f33d, 0x1f33e,
                0x1f33f, 0x1f340, 0x1f341, 0x1f342, 0x1f343, 0x1f344, 0x1f345,
                0x1f346, 0x1f347, 0x1f348, 0x1f349, 0x1f34a, 0x1f34b, 0x1f34c,
                0x1f34d, 0x1f34e, 0x1f34f, 0x1f350, 0x1f351, 0x1f352, 0x1f353,
                0x1f354, 0x1f355, 0x1f356, 0x1f357, 0x1f358, 0x1f359, 0x1f35a,
                0x1f35b, 0x1f35c, 0x1f35d, 0x1f35e, 0x1f35f, 0x1f360, 0x1f361,
                0x1f362, 0x1f363, 0x1f364, 0x1f365, 0x1f366, 0x1f367, 0x1f368,
                0x1f369, 0x1f36a, 0x1f36b, 0x1f36c, 0x1f36d, 0x1f36e, 0x1f36f,
                0x1f370, 0x1f371, 0x1f372, 0x1f373, 0x1f374, 0x1f375, 0x1f376,
                0x1f377, 0x1f378, 0x1f379, 0x1f37a, 0x1f37b, 0x1f37c, 0x1f37d,
                0x1f37e, 0x1f37f, 0x1f380, 0x1f381, 0x1f382, 0x1f383, 0x1f384,
                0x1f385, 0x1f386, 0x1f387, 0x1f388, 0x1f389, 0x1f38a, 0x1f38b,
                0x1f38c, 0x1f38d, 0x1f38e, 0x1f38f, 0x1f390, 0x1f391, 0x1f392,
                0x1f393, 0x1f396, 0x1f397, 0x1f399, 0x1f39a, 0x1f39b, 0x1f39e,
                0x1f39f, 0x1f3a0, 0x1f3a1, 0x1f3a2, 0x1f3a3, 0x1f3a4, 0x1f3a5,
                0x1f3a6, 0x1f3a7, 0x1f3a8, 0x1f3a9, 0x1f3aa, 0x1f3ab, 0x1f3ac,
                0x1f3ad, 0x1f3ae, 0x1f3af, 0x1f3b0, 0x1f3b1, 0x1f3b2, 0x1f3b3,
                0x1f3b4, 0x1f3b5, 0x1f3b6, 0x1f3b7, 0x1f3b8, 0x1f3b9, 0x1f3ba,
                0x1f3bb, 0x1f3bc, 0x1f3bd, 0x1f3be, 0x1f3bf, 0x1f3c0, 0x1f3c1,
                0x1f3c2, 0x1f3c3, 0x1f3c4, 0x1f3c5, 0x1f3c6, 0x1f3c7, 0x1f3c8,
                0x1f3c9, 0x1f3ca, 0x1f3cb, 0x1f3cc, 0x1f3cd, 0x1f3ce, 0x1f3cf,
                0x1f3d0, 0x1f3d1, 0x1f3d2, 0x1f3d3, 0x1f3d4, 0x1f3d5, 0x1f3d6,
                0x1f3d7, 0x1f3d8, 0x1f3d9, 0x1f3da, 0x1f3db, 0x1f3dc, 0x1f3dd,
                0x1f3de, 0x1f3df, 0x1f3e0, 0x1f3e1, 0x1f3e2, 0x1f3e3, 0x1f3e4,
                0x1f3e5, 0x1f3e6, 0x1f3e7, 0x1f3e8, 0x1f3e9, 0x1f3ea, 0x1f3eb,
                0x1f3ec, 0x1f3ed, 0x1f3ee, 0x1f3ef, 0x1f3f0, 0x1f3f3, 0x1f3f4,
                0x1f3f5, 0x1f3f7, 0x1f3f8, 0x1f3f9, 0x1f3fa, 0x1f3fb, 0x1f3fc,
                0x1f3fd, 0x1f3fe, 0x1f3ff, 0x1f400, 0x1f401, 0x1f402, 0x1f403,
                0x1f404, 0x1f405, 0x1f406, 0x1f407, 0x1f408, 0x1f409, 0x1f40a,
                0x1f40b, 0x1f40c, 0x1f40d, 0x1f40e, 0x1f40f, 0x1f410, 0x1f411,
                0x1f412, 0x1f413, 0x1f414, 0x1f415, 0x1f416, 0x1f417, 0x1f418,
                0x1f419, 0x1f41a, 0x1f41b, 0x1f41c, 0x1f41d, 0x1f41e, 0x1f41f,
                0x1f420, 0x1f421, 0x1f422, 0x1f423, 0x1f424, 0x1f425, 0x1f426,
                0x1f427, 0x1f428, 0x1f429, 0x1f42a, 0x1f42b, 0x1f42c, 0x1f42d,
                0x1f42e, 0x1f42f, 0x1f430, 0x1f431, 0x1f432, 0x1f433, 0x1f434,
                0x1f435, 0x1f436, 0x1f437, 0x1f438, 0x1f439, 0x1f43a, 0x1f43b,
                0x1f43c, 0x1f43d, 0x1f43e, 0x1f43f, 0x1f440, 0x1f441, 0x1f442,
                0x1f443, 0x1f444, 0x1f445, 0x1f446, 0x1f447, 0x1f448, 0x1f449,
                0x1f44a, 0x1f44b, 0x1f44c, 0x1f44d, 0x1f44e, 0x1f44f, 0x1f450,
                0x1f451, 0x1f452, 0x1f453, 0x1f454, 0x1f455, 0x1f456, 0x1f457,
                0x1f458, 0x1f459, 0x1f45a, 0x1f45b, 0x1f45c, 0x1f45d, 0x1f45e,
                0x1f45f, 0x1f460, 0x1f461, 0x1f462, 0x1f463, 0x1f464, 0x1f465,
                0x1f466, 0x1f467, 0x1f468, 0x1f469, 0x1f46a, 0x1f46b, 0x1f46c,
                0x1f46d, 0x1f46e, 0x1f46f, 0x1f470, 0x1f471, 0x1f472, 0x1f473,
                0x1f474, 0x1f475, 0x1f476, 0x1f477, 0x1f478, 0x1f479, 0x1f47a,
                0x1f47b, 0x1f47c, 0x1f47d, 0x1f47e, 0x1f47f, 0x1f480, 0x1f481,
                0x1f482, 0x1f483, 0x1f484, 0x1f485, 0x1f486, 0x1f487, 0x1f488,
                0x1f489, 0x1f48a, 0x1f48b, 0x1f48c, 0x1f48d, 0x1f48e, 0x1f48f,
                0x1f490, 0x1f491, 0x1f492, 0x1f493, 0x1f494, 0x1f495, 0x1f496,
                0x1f497, 0x1f498, 0x1f499, 0x1f49a, 0x1f49b, 0x1f49c, 0x1f49d,
                0x1f49e, 0x1f49f, 0x1f4a0, 0x1f4a1, 0x1f4a2, 0x1f4a3, 0x1f4a4,
                0x1f4a5, 0x1f4a6, 0x1f4a7, 0x1f4a8, 0x1f4a9, 0x1f4aa, 0x1f4ab,
                0x1f4ac, 0x1f4ad, 0x1f4ae, 0x1f4af, 0x1f4b0, 0x1f4b1, 0x1f4b2,
                0x1f4b3, 0x1f4b4, 0x1f4b5, 0x1f4b6, 0x1f4b7, 0x1f4b8, 0x1f4b9,
                0x1f4ba, 0x1f4bb, 0x1f4bc, 0x1f4bd, 0x1f4be, 0x1f4bf, 0x1f4c0,
                0x1f4c1, 0x1f4c2, 0x1f4c3, 0x1f4c4, 0x1f4c5, 0x1f4c6, 0x1f4c7,
                0x1f4c8, 0x1f4c9, 0x1f4ca, 0x1f4cb, 0x1f4cc, 0x1f4cd, 0x1f4ce,
                0x1f4cf, 0x1f4d0, 0x1f4d1, 0x1f4d2, 0x1f4d3, 0x1f4d4, 0x1f4d5,
                0x1f4d6, 0x1f4d7, 0x1f4d8, 0x1f4d9, 0x1f4da, 0x1f4db, 0x1f4dc,
                0x1f4dd, 0x1f4de, 0x1f4df, 0x1f4e0, 0x1f4e1, 0x1f4e2, 0x1f4e3,
                0x1f4e4, 0x1f4e5, 0x1f4e6, 0x1f4e7, 0x1f4e8, 0x1f4e9, 0x1f4ea,
                0x1f4eb, 0x1f4ec, 0x1f4ed, 0x1f4ee, 0x1f4ef, 0x1f4f0, 0x1f4f1,
                0x1f4f2, 0x1f4f3, 0x1f4f4, 0x1f4f5, 0x1f4f6, 0x1f4f7, 0x1f4f8,
                0x1f4f9, 0x1f4fa, 0x1f4fb, 0x1f4fc, 0x1f4fd, 0x1f4ff, 0x1f500,
                0x1f501, 0x1f502, 0x1f503, 0x1f504, 0x1f505, 0x1f506, 0x1f507,
                0x1f508, 0x1f509, 0x1f50a, 0x1f50b, 0x1f50c, 0x1f50d, 0x1f50e,
                0x1f50f, 0x1f510, 0x1f511, 0x1f512, 0x1f513, 0x1f514, 0x1f515,
                0x1f516, 0x1f517, 0x1f518, 0x1f519, 0x1f51a, 0x1f51b, 0x1f51c,
                0x1f51d, 0x1f51e, 0x1f51f, 0x1f520, 0x1f521, 0x1f522, 0x1f523,
                0x1f524, 0x1f525, 0x1f526, 0x1f527, 0x1f528, 0x1f529, 0x1f52a,
                0x1f52b, 0x1f52c, 0x1f52d, 0x1f52e, 0x1f52f, 0x1f530, 0x1f531,
                0x1f532, 0x1f533, 0x1f534, 0x1f535, 0x1f536, 0x1f537, 0x1f538,
                0x1f539, 0x1f53a, 0x1f53b, 0x1f53c, 0x1f53d, 0x1f549, 0x1f54a,
                0x1f54b, 0x1f54c, 0x1f54d, 0x1f54e, 0x1f550, 0x1f551, 0x1f552,
                0x1f553, 0x1f554, 0x1f555, 0x1f556, 0x1f557, 0x1f558, 0x1f559,
                0x1f55a, 0x1f55b, 0x1f55c, 0x1f55d, 0x1f55e, 0x1f55f, 0x1f560,
                0x1f561, 0x1f562, 0x1f563, 0x1f564, 0x1f565, 0x1f566, 0x1f567,
                0x1f56f, 0x1f570, 0x1f573, 0x1f574, 0x1f575, 0x1f576, 0x1f577,
                0x1f578, 0x1f579, 0x1f57a, 0x1f587, 0x1f58a, 0x1f58b, 0x1f58c,
                0x1f58d, 0x1f590, 0x1f595, 0x1f596, 0x1f5a4, 0x1f5a5, 0x1f5a8,
                0x1f5b1, 0x1f5b2, 0x1f5bc, 0x1f5c2, 0x1f5c3, 0x1f5c4, 0x1f5d1,
                0x1f5d2, 0x1f5d3, 0x1f5dc, 0x1f5dd, 0x1f5de, 0x1f5e1, 0x1f5e3,
                0x1f5e8, 0x1f5ef, 0x1f5f3, 0x1f5fa, 0x1f5fb, 0x1f5fc, 0x1f5fd,
                0x1f5fe, 0x1f5ff, 0x1f600, 0x1f601, 0x1f602, 0x1f603, 0x1f604,
                0x1f605, 0x1f606, 0x1f607, 0x1f608, 0x1f609, 0x1f60a, 0x1f60b,
                0x1f60c, 0x1f60d, 0x1f60e, 0x1f60f, 0x1f610, 0x1f611, 0x1f612,
                0x1f613, 0x1f614, 0x1f615, 0x1f616, 0x1f617, 0x1f618, 0x1f619,
                0x1f61a, 0x1f61b, 0x1f61c, 0x1f61d, 0x1f61e, 0x1f61f, 0x1f620,
                0x1f621, 0x1f622, 0x1f623, 0x1f624, 0x1f625, 0x1f626, 0x1f627,
                0x1f628, 0x1f629, 0x1f62a, 0x1f62b, 0x1f62c, 0x1f62d, 0x1f62e,
                0x1f62f, 0x1f630, 0x1f631, 0x1f632, 0x1f633, 0x1f634, 0x1f635,
                0x1f636, 0x1f637, 0x1f638, 0x1f639, 0x1f63a, 0x1f63b, 0x1f63c,
                0x1f63d, 0x1f63e, 0x1f63f, 0x1f640, 0x1f641, 0x1f642, 0x1f643,
                0x1f644, 0x1f645, 0x1f646, 0x1f647, 0x1f648, 0x1f649, 0x1f64a,
                0x1f64b, 0x1f64c, 0x1f64d, 0x1f64e, 0x1f64f, 0x1f680, 0x1f681,
                0x1f682, 0x1f683, 0x1f684, 0x1f685, 0x1f686, 0x1f687, 0x1f688,
                0x1f689, 0x1f68a, 0x1f68b, 0x1f68c, 0x1f68d, 0x1f68e, 0x1f68f,
                0x1f690, 0x1f691, 0x1f692, 0x1f693, 0x1f694, 0x1f695, 0x1f696,
                0x1f697, 0x1f698, 0x1f699, 0x1f69a, 0x1f69b, 0x1f69c, 0x1f69d,
                0x1f69e, 0x1f69f, 0x1f6a0, 0x1f6a1, 0x1f6a2, 0x1f6a3, 0x1f6a4,
                0x1f6a5, 0x1f6a6, 0x1f6a7, 0x1f6a8, 0x1f6a9, 0x1f6aa, 0x1f6ab,
                0x1f6ac, 0x1f6ad, 0x1f6ae, 0x1f6af, 0x1f6b0, 0x1f6b1, 0x1f6b2,
                0x1f6b3, 0x1f6b4, 0x1f6b5, 0x1f6b6, 0x1f6b7, 0x1f6b8, 0x1f6b9,
                0x1f6ba, 0x1f6bb, 0x1f6bc, 0x1f6bd, 0x1f6be, 0x1f6bf, 0x1f6c0,
                0x1f6c1, 0x1f6c2, 0x1f6c3, 0x1f6c4, 0x1f6c5, 0x1f6cb, 0x1f6cc,
                0x1f6cd, 0x1f6ce, 0x1f6cf, 0x1f6d0, 0x1f6d1, 0x1f6d2, 0x1f6d5,
                0x1f6e0, 0x1f6e1, 0x1f6e2, 0x1f6e3, 0x1f6e4, 0x1f6e5, 0x1f6e9,
                0x1f6eb, 0x1f6ec, 0x1f6f0, 0x1f6f3, 0x1f6f4, 0x1f6f5, 0x1f6f6,
                0x1f6f7, 0x1f6f8, 0x1f6f9, 0x1f6fa, 0x1f7e0, 0x1f7e1, 0x1f7e2,
                0x1f7e3, 0x1f7e4, 0x1f7e5, 0x1f7e6, 0x1f7e7, 0x1f7e8, 0x1f7e9,
                0x1f7ea, 0x1f7eb, 0x1f90d, 0x1f90e, 0x1f90f, 0x1f910, 0x1f911,
                0x1f912, 0x1f913, 0x1f914, 0x1f915, 0x1f916, 0x1f917, 0x1f918,
                0x1f919, 0x1f91a, 0x1f91b, 0x1f91c, 0x1f91d, 0x1f91e, 0x1f91f,
                0x1f920, 0x1f921, 0x1f922, 0x1f923, 0x1f924, 0x1f925, 0x1f926,
                0x1f927, 0x1f928, 0x1f929, 0x1f92a, 0x1f92b, 0x1f92c, 0x1f92d,
                0x1f92e, 0x1f92f, 0x1f930, 0x1f931, 0x1f932, 0x1f933, 0x1f934,
                0x1f935, 0x1f936, 0x1f937, 0x1f938, 0x1f939, 0x1f93a, 0x1f93c,
                0x1f93d, 0x1f93e, 0x1f93f, 0x1f940, 0x1f941, 0x1f942, 0x1f943,
                0x1f944, 0x1f945, 0x1f947, 0x1f948, 0x1f949, 0x1f94a, 0x1f94b,
                0x1f94c, 0x1f94d, 0x1f94e, 0x1f94f, 0x1f950, 0x1f951, 0x1f952,
                0x1f953, 0x1f954, 0x1f955, 0x1f956, 0x1f957, 0x1f958, 0x1f959,
                0x1f95a, 0x1f95b, 0x1f95c, 0x1f95d, 0x1f95e, 0x1f95f, 0x1f960,
                0x1f961, 0x1f962, 0x1f963, 0x1f964, 0x1f965, 0x1f966, 0x1f967,
                0x1f968, 0x1f969, 0x1f96a, 0x1f96b, 0x1f96c, 0x1f96d, 0x1f96e,
                0x1f96f, 0x1f970, 0x1f971, 0x1f973, 0x1f974, 0x1f975, 0x1f976,
                0x1f97a, 0x1f97b, 0x1f97c, 0x1f97d, 0x1f97e, 0x1f97f, 0x1f980,
                0x1f981, 0x1f982, 0x1f983, 0x1f984, 0x1f985, 0x1f986, 0x1f987,
                0x1f988, 0x1f989, 0x1f98a, 0x1f98b, 0x1f98c, 0x1f98d, 0x1f98e,
                0x1f98f, 0x1f990, 0x1f991, 0x1f992, 0x1f993, 0x1f994, 0x1f995,
                0x1f996, 0x1f997, 0x1f998, 0x1f999, 0x1f99a, 0x1f99b, 0x1f99c,
                0x1f99d, 0x1f99e, 0x1f99f, 0x1f9a0, 0x1f9a1, 0x1f9a2, 0x1f9a5,
                0x1f9a6, 0x1f9a7, 0x1f9a8, 0x1f9a9, 0x1f9aa, 0x1f9ae, 0x1f9af,
                0x1f9b0, 0x1f9b1, 0x1f9b2, 0x1f9b3, 0x1f9b4, 0x1f9b5, 0x1f9b6,
                0x1f9b7, 0x1f9b8, 0x1f9b9, 0x1f9ba, 0x1f9bb, 0x1f9bc, 0x1f9bd,
                0x1f9be, 0x1f9bf, 0x1f9c0, 0x1f9c1, 0x1f9c2, 0x1f9c3, 0x1f9c4,
                0x1f9c5, 0x1f9c6, 0x1f9c7, 0x1f9c8, 0x1f9c9, 0x1f9ca, 0x1f9cd,
                0x1f9ce, 0x1f9cf, 0x1f9d0, 0x1f9d1, 0x1f9d2, 0x1f9d3, 0x1f9d4,
                0x1f9d5, 0x1f9d6, 0x1f9d7, 0x1f9d8, 0x1f9d9, 0x1f9da, 0x1f9db,
                0x1f9dc, 0x1f9dd, 0x1f9de, 0x1f9df, 0x1f9e0, 0x1f9e1, 0x1f9e2,
                0x1f9e3, 0x1f9e4, 0x1f9e5, 0x1f9e6, 0x1f9e7, 0x1f9e8, 0x1f9e9,
                0x1f9ea, 0x1f9eb, 0x1f9ec, 0x1f9ed, 0x1f9ee, 0x1f9ef, 0x1f9f0,
                0x1f9f1, 0x1f9f2, 0x1f9f3, 0x1f9f4, 0x1f9f5, 0x1f9f6, 0x1f9f7,
                0x1f9f8, 0x1f9f9, 0x1f9fa, 0x1f9fb, 0x1f9fc, 0x1f9fd, 0x1f9fe,
                0x1f9ff, 0x1fa70, 0x1fa71, 0x1fa72, 0x1fa73, 0x1fa78, 0x1fa79,
                0x1fa7a, 0x1fa80, 0x1fa81, 0x1fa82, 0x1fa90, 0x1fa91, 0x1fa92,
                0x1fa93, 0x1fa94, 0x1fa95, 0x203c, 0x2049, 0x20e3, 0x2122,
                0x2139, 0x2194, 0x2195, 0x2196, 0x2197, 0x2198, 0x2199,
                0x21a9, 0x21aa, 0x231a, 0x231b, 0x2328, 0x23cf, 0x23e9,
                0x23ea, 0x23eb, 0x23ec, 0x23ed, 0x23ee, 0x23ef, 0x23f0,
                0x23f1, 0x23f2, 0x23f3, 0x23f8, 0x23f9, 0x23fa, 0x24c2,
                0x25aa, 0x25ab, 0x25b6, 0x25c0, 0x25fb, 0x25fc, 0x25fd,
                0x25fe, 0x2600, 0x2601, 0x2602, 0x2603, 0x2604, 0x260e,
                0x2611, 0x2614, 0x2615, 0x2618, 0x261d, 0x2620, 0x2622,
                0x2623, 0x2626, 0x262a, 0x262e, 0x262f, 0x2638, 0x2639,
                0x263a, 0x2640, 0x2642, 0x2648, 0x2649, 0x264a, 0x264b,
                0x264c, 0x264d, 0x264e, 0x264f, 0x2650, 0x2651, 0x2652,
                0x2653, 0x265f, 0x2660, 0x2663, 0x2665, 0x2666, 0x2668,
                0x267b, 0x267e, 0x267f, 0x2692, 0x2693, 0x2694, 0x2695,
                0x2696, 0x2697, 0x2699, 0x269b, 0x269c, 0x26a0, 0x26a1,
                0x26aa, 0x26ab, 0x26b0, 0x26b1, 0x26bd, 0x26be, 0x26c4,
                0x26c5, 0x26c8, 0x26ce, 0x26cf, 0x26d1, 0x26d3, 0x26d4,
                0x26e9, 0x26ea, 0x26f0, 0x26f1, 0x26f2, 0x26f3, 0x26f4,
                0x26f5, 0x26f7, 0x26f8, 0x26f9, 0x26fa, 0x26fd, 0x2702,
                0x2705, 0x2708, 0x2709, 0x270a, 0x270b, 0x270c, 0x270d,
                0x270f, 0x2712, 0x2714, 0x2716, 0x271d, 0x2721, 0x2728,
                0x2733, 0x2734, 0x2744, 0x2747, 0x274c, 0x274e, 0x2753,
                0x2754, 0x2755, 0x2757, 0x2763, 0x2764, 0x2795, 0x2796,
                0x2797, 0x27a1, 0x27b0, 0x27bf, 0x2934, 0x2935, 0x2b05,
                0x2b06, 0x2b07, 0x2b1b, 0x2b1c, 0x2b50, 0x2b55, 0x3030,
                0x303d, 0x3297, 0x3299, 0xa9, 0xae, 0xfe0f
            },
            spriteSheetNumberOfRows: 36,
            spriteSheetNumberOfColumns: 37
        );
        
        public static readonly EmojiResourceConfiguration appleEmojiConfiguration = new EmojiResourceConfiguration(
            "images/EmojiIOS13.2",
            emojiCodes: new List<int> {
                0x1f004, 0x1f0cf, 0x1f170, 0x1f171, 0x1f17e, 0x1f17f, 0x1f18e,
                0x1f191, 0x1f192, 0x1f193, 0x1f194, 0x1f195, 0x1f196, 0x1f197,
                0x1f198, 0x1f199, 0x1f19a, 0x1f201, 0x1f202, 0x1f21a, 0x1f22f,
                0x1f232, 0x1f233, 0x1f234, 0x1f235, 0x1f236, 0x1f237, 0x1f238,
                0x1f239, 0x1f23a, 0x1f250, 0x1f251, 0x1f300, 0x1f301, 0x1f302,
                0x1f303, 0x1f304, 0x1f305, 0x1f306, 0x1f307, 0x1f308, 0x1f309,
                0x1f30a, 0x1f30b, 0x1f30c, 0x1f30d, 0x1f30e, 0x1f30f, 0x1f310,
                0x1f311, 0x1f312, 0x1f313, 0x1f314, 0x1f315, 0x1f316, 0x1f317,
                0x1f318, 0x1f319, 0x1f31a, 0x1f31b, 0x1f31c, 0x1f31d, 0x1f31e,
                0x1f31f, 0x1f320, 0x1f321, 0x1f324, 0x1f325, 0x1f326, 0x1f327,
                0x1f328, 0x1f329, 0x1f32a, 0x1f32b, 0x1f32c, 0x1f32d, 0x1f32e,
                0x1f32f, 0x1f330, 0x1f331, 0x1f332, 0x1f333, 0x1f334, 0x1f335,
                0x1f336, 0x1f337, 0x1f338, 0x1f339, 0x1f33a, 0x1f33b, 0x1f33c,
                0x1f33d, 0x1f33e, 0x1f33f, 0x1f340, 0x1f341, 0x1f342, 0x1f343,
                0x1f344, 0x1f345, 0x1f346, 0x1f347, 0x1f348, 0x1f349, 0x1f34a,
                0x1f34b, 0x1f34c, 0x1f34d, 0x1f34e, 0x1f34f, 0x1f350, 0x1f351,
                0x1f352, 0x1f353, 0x1f354, 0x1f355, 0x1f356, 0x1f357, 0x1f358,
                0x1f359, 0x1f35a, 0x1f35b, 0x1f35c, 0x1f35d, 0x1f35e, 0x1f35f,
                0x1f360, 0x1f361, 0x1f362, 0x1f363, 0x1f364, 0x1f365, 0x1f366,
                0x1f367, 0x1f368, 0x1f369, 0x1f36a, 0x1f36b, 0x1f36c, 0x1f36d,
                0x1f36e, 0x1f36f, 0x1f370, 0x1f371, 0x1f372, 0x1f373, 0x1f374,
                0x1f375, 0x1f376, 0x1f377, 0x1f378, 0x1f379, 0x1f37a, 0x1f37b,
                0x1f37c, 0x1f37d, 0x1f37e, 0x1f37f, 0x1f380, 0x1f381, 0x1f382,
                0x1f383, 0x1f384, 0x1f385, 0x1f386, 0x1f387, 0x1f388, 0x1f389,
                0x1f38a, 0x1f38b, 0x1f38c, 0x1f38d, 0x1f38e, 0x1f38f, 0x1f390,
                0x1f391, 0x1f392, 0x1f393, 0x1f396, 0x1f397, 0x1f399, 0x1f39a,
                0x1f39b, 0x1f39e, 0x1f39f, 0x1f3a0, 0x1f3a1, 0x1f3a2, 0x1f3a3,
                0x1f3a4, 0x1f3a5, 0x1f3a6, 0x1f3a7, 0x1f3a8, 0x1f3a9, 0x1f3aa,
                0x1f3ab, 0x1f3ac, 0x1f3ad, 0x1f3ae, 0x1f3af, 0x1f3b0, 0x1f3b1,
                0x1f3b2, 0x1f3b3, 0x1f3b4, 0x1f3b5, 0x1f3b6, 0x1f3b7, 0x1f3b8,
                0x1f3b9, 0x1f3ba, 0x1f3bb, 0x1f3bc, 0x1f3bd, 0x1f3be, 0x1f3bf,
                0x1f3c0, 0x1f3c1, 0x1f3c2, 0x1f3c3, 0x1f3c4, 0x1f3c5, 0x1f3c6,
                0x1f3c7, 0x1f3c8, 0x1f3c9, 0x1f3ca, 0x1f3cb, 0x1f3cc, 0x1f3cd,
                0x1f3ce, 0x1f3cf, 0x1f3d0, 0x1f3d1, 0x1f3d2, 0x1f3d3, 0x1f3d4,
                0x1f3d5, 0x1f3d6, 0x1f3d7, 0x1f3d8, 0x1f3d9, 0x1f3da, 0x1f3db,
                0x1f3dc, 0x1f3dd, 0x1f3de, 0x1f3df, 0x1f3e0, 0x1f3e1, 0x1f3e2,
                0x1f3e3, 0x1f3e4, 0x1f3e5, 0x1f3e6, 0x1f3e7, 0x1f3e8, 0x1f3e9,
                0x1f3ea, 0x1f3eb, 0x1f3ec, 0x1f3ed, 0x1f3ee, 0x1f3ef, 0x1f3f0,
                0x1f3f3, 0x1f3f4, 0x1f3f5, 0x1f3f7, 0x1f3f8, 0x1f3f9, 0x1f3fa,
                0x1f3fb, 0x1f3fc, 0x1f3fd, 0x1f3fe, 0x1f3ff, 0x1f400, 0x1f401,
                0x1f402, 0x1f403, 0x1f404, 0x1f405, 0x1f406, 0x1f407, 0x1f408,
                0x1f409, 0x1f40a, 0x1f40b, 0x1f40c, 0x1f40d, 0x1f40e, 0x1f40f,
                0x1f410, 0x1f411, 0x1f412, 0x1f413, 0x1f414, 0x1f415, 0x1f416,
                0x1f417, 0x1f418, 0x1f419, 0x1f41a, 0x1f41b, 0x1f41c, 0x1f41d,
                0x1f41e, 0x1f41f, 0x1f420, 0x1f421, 0x1f422, 0x1f423, 0x1f424,
                0x1f425, 0x1f426, 0x1f427, 0x1f428, 0x1f429, 0x1f42a, 0x1f42b,
                0x1f42c, 0x1f42d, 0x1f42e, 0x1f42f, 0x1f430, 0x1f431, 0x1f432,
                0x1f433, 0x1f434, 0x1f435, 0x1f436, 0x1f437, 0x1f438, 0x1f439,
                0x1f43a, 0x1f43b, 0x1f43c, 0x1f43d, 0x1f43e, 0x1f43f, 0x1f440,
                0x1f441, 0x1f442, 0x1f443, 0x1f444, 0x1f445, 0x1f446, 0x1f447,
                0x1f448, 0x1f449, 0x1f44a, 0x1f44b, 0x1f44c, 0x1f44d, 0x1f44e,
                0x1f44f, 0x1f450, 0x1f451, 0x1f452, 0x1f453, 0x1f454, 0x1f455,
                0x1f456, 0x1f457, 0x1f458, 0x1f459, 0x1f45a, 0x1f45b, 0x1f45c,
                0x1f45d, 0x1f45e, 0x1f45f, 0x1f460, 0x1f461, 0x1f462, 0x1f463,
                0x1f464, 0x1f465, 0x1f466, 0x1f467, 0x1f468, 0x1f469, 0x1f46a,
                0x1f46b, 0x1f46c, 0x1f46d, 0x1f46e, 0x1f46f, 0x1f470, 0x1f471,
                0x1f472, 0x1f473, 0x1f474, 0x1f475, 0x1f476, 0x1f477, 0x1f478,
                0x1f479, 0x1f47a, 0x1f47b, 0x1f47c, 0x1f47d, 0x1f47e, 0x1f47f,
                0x1f480, 0x1f481, 0x1f482, 0x1f483, 0x1f484, 0x1f485, 0x1f486,
                0x1f487, 0x1f488, 0x1f489, 0x1f48a, 0x1f48b, 0x1f48c, 0x1f48d,
                0x1f48e, 0x1f48f, 0x1f490, 0x1f491, 0x1f492, 0x1f493, 0x1f494,
                0x1f495, 0x1f496, 0x1f497, 0x1f498, 0x1f499, 0x1f49a, 0x1f49b,
                0x1f49c, 0x1f49d, 0x1f49e, 0x1f49f, 0x1f4a0, 0x1f4a1, 0x1f4a2,
                0x1f4a3, 0x1f4a4, 0x1f4a5, 0x1f4a6, 0x1f4a7, 0x1f4a8, 0x1f4a9,
                0x1f4aa, 0x1f4ab, 0x1f4ac, 0x1f4ad, 0x1f4ae, 0x1f4af, 0x1f4b0,
                0x1f4b1, 0x1f4b2, 0x1f4b3, 0x1f4b4, 0x1f4b5, 0x1f4b6, 0x1f4b7,
                0x1f4b8, 0x1f4b9, 0x1f4ba, 0x1f4bb, 0x1f4bc, 0x1f4bd, 0x1f4be,
                0x1f4bf, 0x1f4c0, 0x1f4c1, 0x1f4c2, 0x1f4c3, 0x1f4c4, 0x1f4c5,
                0x1f4c6, 0x1f4c7, 0x1f4c8, 0x1f4c9, 0x1f4ca, 0x1f4cb, 0x1f4cc,
                0x1f4cd, 0x1f4ce, 0x1f4cf, 0x1f4d0, 0x1f4d1, 0x1f4d2, 0x1f4d3,
                0x1f4d4, 0x1f4d5, 0x1f4d6, 0x1f4d7, 0x1f4d8, 0x1f4d9, 0x1f4da,
                0x1f4db, 0x1f4dc, 0x1f4dd, 0x1f4de, 0x1f4df, 0x1f4e0, 0x1f4e1,
                0x1f4e2, 0x1f4e3, 0x1f4e4, 0x1f4e5, 0x1f4e6, 0x1f4e7, 0x1f4e8,
                0x1f4e9, 0x1f4ea, 0x1f4eb, 0x1f4ec, 0x1f4ed, 0x1f4ee, 0x1f4ef,
                0x1f4f0, 0x1f4f1, 0x1f4f2, 0x1f4f3, 0x1f4f4, 0x1f4f5, 0x1f4f6,
                0x1f4f7, 0x1f4f8, 0x1f4f9, 0x1f4fa, 0x1f4fb, 0x1f4fc, 0x1f4fd,
                0x1f4ff, 0x1f500, 0x1f501, 0x1f502, 0x1f503, 0x1f504, 0x1f505,
                0x1f506, 0x1f507, 0x1f508, 0x1f509, 0x1f50a, 0x1f50b, 0x1f50c,
                0x1f50d, 0x1f50e, 0x1f50f, 0x1f510, 0x1f511, 0x1f512, 0x1f513,
                0x1f514, 0x1f515, 0x1f516, 0x1f517, 0x1f518, 0x1f519, 0x1f51a,
                0x1f51b, 0x1f51c, 0x1f51d, 0x1f51e, 0x1f51f, 0x1f520, 0x1f521,
                0x1f522, 0x1f523, 0x1f524, 0x1f525, 0x1f526, 0x1f527, 0x1f528,
                0x1f529, 0x1f52a, 0x1f52b, 0x1f52c, 0x1f52d, 0x1f52e, 0x1f52f,
                0x1f530, 0x1f531, 0x1f532, 0x1f533, 0x1f534, 0x1f535, 0x1f536,
                0x1f537, 0x1f538, 0x1f539, 0x1f53a, 0x1f53b, 0x1f53c, 0x1f53d,
                0x1f549, 0x1f54a, 0x1f54b, 0x1f54c, 0x1f54d, 0x1f54e, 0x1f550,
                0x1f551, 0x1f552, 0x1f553, 0x1f554, 0x1f555, 0x1f556, 0x1f557,
                0x1f558, 0x1f559, 0x1f55a, 0x1f55b, 0x1f55c, 0x1f55d, 0x1f55e,
                0x1f55f, 0x1f560, 0x1f561, 0x1f562, 0x1f563, 0x1f564, 0x1f565,
                0x1f566, 0x1f567, 0x1f56f, 0x1f570, 0x1f573, 0x1f574, 0x1f575,
                0x1f576, 0x1f577, 0x1f578, 0x1f579, 0x1f57a, 0x1f587, 0x1f58a,
                0x1f58b, 0x1f58c, 0x1f58d, 0x1f590, 0x1f595, 0x1f596, 0x1f5a4,
                0x1f5a5, 0x1f5a8, 0x1f5b1, 0x1f5b2, 0x1f5bc, 0x1f5c2, 0x1f5c3,
                0x1f5c4, 0x1f5d1, 0x1f5d2, 0x1f5d3, 0x1f5dc, 0x1f5dd, 0x1f5de,
                0x1f5e1, 0x1f5e3, 0x1f5e8, 0x1f5ef, 0x1f5f3, 0x1f5fa, 0x1f5fb,
                0x1f5fc, 0x1f5fd, 0x1f5fe, 0x1f5ff, 0x1f601, 0x1f602, 0x1f603,
                0x1f604, 0x1f605, 0x1f606, 0x1f607, 0x1f608, 0x1f609, 0x1f60a,
                0x1f60b, 0x1f60c, 0x1f60d, 0x1f60e, 0x1f60f, 0x1f610, 0x1f611,
                0x1f612, 0x1f613, 0x1f614, 0x1f615, 0x1f616, 0x1f617, 0x1f618,
                0x1f619, 0x1f61a, 0x1f61b, 0x1f61c, 0x1f61d, 0x1f61e, 0x1f61f,
                0x1f620, 0x1f621, 0x1f622, 0x1f623, 0x1f624, 0x1f625, 0x1f626,
                0x1f627, 0x1f628, 0x1f629, 0x1f62a, 0x1f62b, 0x1f62c, 0x1f62d,
                0x1f62e, 0x1f62f, 0x1f630, 0x1f631, 0x1f632, 0x1f633, 0x1f634,
                0x1f635, 0x1f636, 0x1f637, 0x1f638, 0x1f639, 0x1f63a, 0x1f63b,
                0x1f63c, 0x1f63d, 0x1f63e, 0x1f63f, 0x1f640, 0x1f641, 0x1f642,
                0x1f643, 0x1f644, 0x1f645, 0x1f646, 0x1f647, 0x1f648, 0x1f649,
                0x1f64a, 0x1f64b, 0x1f64c, 0x1f64d, 0x1f64e, 0x1f64f, 0x1f680,
                0x1f681, 0x1f682, 0x1f683, 0x1f684, 0x1f685, 0x1f686, 0x1f687,
                0x1f688, 0x1f689, 0x1f68a, 0x1f68b, 0x1f68c, 0x1f68d, 0x1f68e,
                0x1f68f, 0x1f690, 0x1f691, 0x1f692, 0x1f693, 0x1f694, 0x1f695,
                0x1f696, 0x1f697, 0x1f698, 0x1f699, 0x1f69a, 0x1f69b, 0x1f69c,
                0x1f69d, 0x1f69e, 0x1f69f, 0x1f6a0, 0x1f6a1, 0x1f6a2, 0x1f6a3,
                0x1f6a4, 0x1f6a5, 0x1f6a6, 0x1f6a7, 0x1f6a8, 0x1f6a9, 0x1f6aa,
                0x1f6ab, 0x1f6ac, 0x1f6ad, 0x1f6ae, 0x1f6af, 0x1f6b0, 0x1f6b1,
                0x1f6b2, 0x1f6b3, 0x1f6b4, 0x1f6b5, 0x1f6b6, 0x1f6b7, 0x1f6b8,
                0x1f6b9, 0x1f6ba, 0x1f6bb, 0x1f6bc, 0x1f6bd, 0x1f6be, 0x1f6bf,
                0x1f6c0, 0x1f6c1, 0x1f6c2, 0x1f6c3, 0x1f6c4, 0x1f6c5, 0x1f6cb,
                0x1f6cc, 0x1f6cd, 0x1f6ce, 0x1f6cf, 0x1f6d0, 0x1f6d1, 0x1f6d2,
                0x1f6d5, 0x1f6e0, 0x1f6e1, 0x1f6e2, 0x1f6e3, 0x1f6e4, 0x1f6e5,
                0x1f6e9, 0x1f6eb, 0x1f6ec, 0x1f6f0, 0x1f6f3, 0x1f6f4, 0x1f6f5,
                0x1f6f6, 0x1f6f7, 0x1f6f8, 0x1f6f9, 0x1f6fa, 0x1f7e0, 0x1f7e1,
                0x1f7e2, 0x1f7e3, 0x1f7e4, 0x1f7e5, 0x1f7e6, 0x1f7e7, 0x1f7e8,
                0x1f7e9, 0x1f7ea, 0x1f7eb, 0x1f90d, 0x1f90e, 0x1f90f, 0x1f910,
                0x1f911, 0x1f912, 0x1f913, 0x1f914, 0x1f915, 0x1f916, 0x1f917,
                0x1f918, 0x1f919, 0x1f91a, 0x1f91b, 0x1f91c, 0x1f91d, 0x1f91e,
                0x1f91f, 0x1f920, 0x1f921, 0x1f922, 0x1f923, 0x1f924, 0x1f925,
                0x1f926, 0x1f927, 0x1f928, 0x1f929, 0x1f92a, 0x1f92b, 0x1f92c,
                0x1f92d, 0x1f92e, 0x1f92f, 0x1f930, 0x1f931, 0x1f932, 0x1f933,
                0x1f934, 0x1f935, 0x1f936, 0x1f937, 0x1f938, 0x1f939, 0x1f93a,
                0x1f93c, 0x1f93d, 0x1f93e, 0x1f93f, 0x1f940, 0x1f941, 0x1f942,
                0x1f943, 0x1f944, 0x1f945, 0x1f947, 0x1f948, 0x1f949, 0x1f94a,
                0x1f94b, 0x1f94c, 0x1f94d, 0x1f94e, 0x1f94f, 0x1f950, 0x1f951,
                0x1f952, 0x1f953, 0x1f954, 0x1f955, 0x1f956, 0x1f957, 0x1f958,
                0x1f959, 0x1f95a, 0x1f95b, 0x1f95c, 0x1f95d, 0x1f95e, 0x1f95f,
                0x1f960, 0x1f961, 0x1f962, 0x1f963, 0x1f964, 0x1f965, 0x1f966,
                0x1f967, 0x1f968, 0x1f969, 0x1f96a, 0x1f96b, 0x1f96c, 0x1f96d,
                0x1f96e, 0x1f96f, 0x1f970, 0x1f971, 0x1f973, 0x1f974, 0x1f975,
                0x1f976, 0x1f97a, 0x1f97b, 0x1f97c, 0x1f97d, 0x1f97e, 0x1f97f,
                0x1f980, 0x1f981, 0x1f982, 0x1f983, 0x1f984, 0x1f985, 0x1f986,
                0x1f987, 0x1f988, 0x1f989, 0x1f98a, 0x1f98b, 0x1f98c, 0x1f98d,
                0x1f98e, 0x1f98f, 0x1f990, 0x1f991, 0x1f992, 0x1f993, 0x1f994,
                0x1f995, 0x1f996, 0x1f997, 0x1f998, 0x1f999, 0x1f99a, 0x1f99b,
                0x1f99c, 0x1f99d, 0x1f99e, 0x1f99f, 0x1f9a0, 0x1f9a1, 0x1f9a2,
                0x1f9a5, 0x1f9a6, 0x1f9a7, 0x1f9a8, 0x1f9a9, 0x1f9aa, 0x1f9ae,
                0x1f9af, 0x1f9b0, 0x1f9b1, 0x1f9b2, 0x1f9b3, 0x1f9b4, 0x1f9b5,
                0x1f9b6, 0x1f9b7, 0x1f9b8, 0x1f9b9, 0x1f9ba, 0x1f9bb, 0x1f9bc,
                0x1f9bd, 0x1f9be, 0x1f9bf, 0x1f9c0, 0x1f9c1, 0x1f9c2, 0x1f9c3,
                0x1f9c4, 0x1f9c5, 0x1f9c6, 0x1f9c7, 0x1f9c8, 0x1f9c9, 0x1f9ca,
                0x1f9cd, 0x1f9ce, 0x1f9cf, 0x1f9d0, 0x1f9d1, 0x1f9d2, 0x1f9d3,
                0x1f9d4, 0x1f9d5, 0x1f9d6, 0x1f9d7, 0x1f9d8, 0x1f9d9, 0x1f9da,
                0x1f9db, 0x1f9dc, 0x1f9dd, 0x1f9de, 0x1f9df, 0x1f9e0, 0x1f9e1,
                0x1f9e2, 0x1f9e3, 0x1f9e4, 0x1f9e5, 0x1f9e6, 0x1f9e7, 0x1f9e8,
                0x1f9e9, 0x1f9ea, 0x1f9eb, 0x1f9ec, 0x1f9ed, 0x1f9ee, 0x1f9ef,
                0x1f9f0, 0x1f9f1, 0x1f9f2, 0x1f9f3, 0x1f9f4, 0x1f9f5, 0x1f9f6,
                0x1f9f7, 0x1f9f8, 0x1f9f9, 0x1f9fa, 0x1f9fb, 0x1f9fc, 0x1f9fd,
                0x1f9fe, 0x1f9ff, 0x1fa70, 0x1fa71, 0x1fa72, 0x1fa73, 0x1fa78,
                0x1fa79, 0x1fa7a, 0x1fa80, 0x1fa81, 0x1fa82, 0x1fa90, 0x1fa91,
                0x1fa92, 0x1fa93, 0x1fa94, 0x1fa95, 0x203c, 0x2049, 0x2122,
                0x2139, 0x2194, 0x2195, 0x2196, 0x2197, 0x2198, 0x2199,
                0x21a9, 0x21aa, 0x231a, 0x231b, 0x2328, 0x23cf, 0x23e9,
                0x23ea, 0x23eb, 0x23ec, 0x23ed, 0x23ee, 0x23ef, 0x23f0,
                0x23f1, 0x23f2, 0x23f3, 0x23f8, 0x23f9, 0x23fa, 0x24c2,
                0x25aa, 0x25ab, 0x25b6, 0x25c0, 0x25fb, 0x25fc, 0x25fd,
                0x25fe, 0x2600, 0x2601, 0x2602, 0x2603, 0x2604, 0x260e,
                0x2611, 0x2614, 0x2615, 0x2618, 0x261d, 0x2620, 0x2622,
                0x2623, 0x2626, 0x262a, 0x262e, 0x262f, 0x2638, 0x2639,
                0x263a, 0x2648, 0x2649, 0x264a, 0x264b, 0x264c, 0x264d,
                0x264e, 0x264f, 0x2650, 0x2651, 0x2652, 0x2653, 0x265f,
                0x2660, 0x2663, 0x2665, 0x2666, 0x2668, 0x267b, 0x267e,
                0x267f, 0x2692, 0x2693, 0x2694, 0x2696, 0x2697, 0x2699,
                0x269b, 0x269c, 0x26a0, 0x26a1, 0x26aa, 0x26ab, 0x26b0,
                0x26b1, 0x26bd, 0x26be, 0x26c4, 0x26c5, 0x26c8, 0x26ce,
                0x26cf, 0x26d1, 0x26d3, 0x26d4, 0x26e9, 0x26ea, 0x26f0,
                0x26f1, 0x26f2, 0x26f3, 0x26f4, 0x26f5, 0x26f7, 0x26f8,
                0x26f9, 0x26fa, 0x26fd, 0x2702, 0x2705, 0x2708, 0x2709,
                0x270a, 0x270b, 0x270c, 0x270d, 0x270f, 0x2712, 0x2714,
                0x2716, 0x271d, 0x2721, 0x2728, 0x2733, 0x2734, 0x2744,
                0x2747, 0x274c, 0x274e, 0x2753, 0x2754, 0x2755, 0x2757,
                0x2763, 0x2764, 0x2795, 0x2796, 0x2797, 0x27a1, 0x27b0,
                0x27bf, 0x2934, 0x2935, 0x2b05, 0x2b06, 0x2b07, 0x2b1b,
                0x2b1c, 0x2b50, 0x2b55, 0x3030, 0x303d, 0x3297, 0x3299,
                0xa9, 0xae, 0xfe0f,
            },
            spriteSheetNumberOfRows: 35,
            spriteSheetNumberOfColumns: 37
        );
        
        static readonly EmojiResourceConfiguration _defaultConfiguration = appleEmojiConfiguration;
        
        static EmojiResourceConfiguration _configuration = null;

        public static EmojiResourceConfiguration configuration {
            get { return _configuration ?? _defaultConfiguration; }
            set {
                if (value == _configuration) {
                    return;
                }

                if (value != null && _configuration != null &&
                    value.spriteSheetAssetName != _configuration.spriteSheetAssetName) {
                    try {
                        _image = new Image(Resources.Load<Texture2D>(value.spriteSheetAssetName));
                    }
                    catch (Exception e) {
                        _image = null;
                        Debug.LogError(e.StackTrace);
                    }
                }
                
                _configuration = value;
            }
        }

        static Image _image;
        public static Image image {
            get {
                if (_image == null || _image.texture == null) {
                    try {
                        _image = new Image(Resources.Load<Texture2D>(configuration.spriteSheetAssetName));
                    }
                    catch (Exception e) {
                        _image = null;
                        Debug.LogError(e.StackTrace);
                    }
                }

                return _image;
            }
        }

        public static Dictionary<int, int> emojiLookupTable {
            get {
                return configuration.emojiLookupTable;
            }
        }

        public static int rowCount {
            get { return configuration.spriteSheetNumberOfRows; }
        }

        public static int colCount {
            get { return configuration.spriteSheetNumberOfColumns; }
        }
        
        public static float advanceFactor = 1.3f;
        public static float sizeFactor = 1.2f;
        public const int emptyEmojiCode = 0xfe0f;

        public static Rect getMinMaxRect(float fontSize, float ascent, float descent) {
            return Rect.fromLTWH((advanceFactor - sizeFactor) / 2 * fontSize,
                descent - fontSize * sizeFactor,
                fontSize * sizeFactor,
                fontSize * sizeFactor);
        }

        public static Rect getUVRect(int code) {
            bool exist = emojiLookupTable.TryGetValue(code, out int index);
            if(!exist) {
                exist = emojiLookupTable.TryGetValue(emptyEmojiCode, out index);
                D.assert(() => {
                    Debug.LogWarning($"Unrecognized unicode for emoji {code:x}");
                    return true;
                });
            }
            if (exist) {
                return Rect.fromLTWH(
                    (index % colCount) * (1.0f / colCount),
                    (rowCount - 1 - (index / colCount)) * (1.0f / rowCount),
                    1.0f / colCount, 1.0f / rowCount);
            }

            return Rect.fromLTWH(0, 0, 0, 0);
        }

        public static bool isSingleCharEmoji(int c) {
            return isSingleCharNonEmptyEmoji(c) || isEmptyEmoji(c);
        }

        public static bool isSingleCharNonEmptyEmoji(int c) {
            return c <= 0xffff && emojiLookupTable.ContainsKey(c);
        }

        public static bool isEmptyEmoji(int c) {
            return c == emptyEmojiCode && !emojiLookupTable.ContainsKey(c);
        }

        public static List<string> splitByEmoji(string text) {
            int start = 0;
            bool? currentEmoji = null;
            List<string> list = new List<string>();

            for (int i = 0; i < text.Length; i++) {
                if (i < text.Length - 1 && char.IsHighSurrogate(text[i]) && char.IsLowSurrogate(text[i + 1])) {
                    if (currentEmoji != true) {
                        if (i > start) {
                            list.Add(text.Substring(start, i - start));
                            start = i;
                        }
                    }

                    i++;
                    currentEmoji = true;
                }
                else if (isSingleCharEmoji(text[i])) {
                    if (currentEmoji != true) {
                        if (i > start) {
                            list.Add(text.Substring(start, i - start));
                            start = i;
                        }
                    }

                    currentEmoji = true;
                }
                else {
                    if (currentEmoji != false) {
                        if (i > start) {
                            list.Add(text.Substring(start, i - start));
                            start = i;
                        }
                    }

                    currentEmoji = false;
                }
            }

            if (start < text.Length) {
                list.Add(text.Substring(start));
            }

            return list;
        }
    }
}