using System;

namespace Tetris
{
    public class BlockQueue
    {
        private readonly Block[] blocks = new Block[]
        {
            new OBlock(),
            new IBlock(),
            new L_Block(),
            new JBlock(),
            new S_Block(),
            new Z_Block(),
            new T_Block()
        };

        private readonly Random random = new Random();

        public Block NextBlock{  get; private set; }

        public BlockQueue()
        {
            NextBlock = RandomBlock();
        }

        private Block RandomBlock()
        {
            return blocks[random.Next(blocks.Length)];
        }

        public Block GetAndUpdate()
        {
            Block block = NextBlock;

            do
            {
                NextBlock = RandomBlock();
            }
            while(block.Id == NextBlock.Id);

            return block;
        }
    }
}
