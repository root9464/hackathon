'use client'

import { applySolidInversion } from '@mui/joy/colorInversion';
import Box from '@mui/joy/Box';
import Button from '@mui/joy/Button';
import Typography from '@mui/joy/Typography';

function Stat({
  description,
  value,
}: {
  description: React.ReactNode;
  value: React.ReactNode;
}) {
  return (
    <Box sx={{ borderLeft: 3, borderColor: 'divider', px: 2, py: 0.5 }}>
      <Typography level="h3" component="div">
        {value}
      </Typography>
      <Typography level="title-sm" textColor="text.secondary">
        {description}
      </Typography>
    </Box>
  );
}

const Price = ({props}:any) => {
  
  return (
    <div className='pos4'>
        <Box 
        sx={[
            {
            display: 'grid',
            width: '800px',
            marginLeft:'50px',
            marginBottom:'125px',
            gridTemplateColumns: { sm: '1fr 1fr' },
            alignItems: 'center',
            rowGap: 2,
            columnGap: 8,
            p: 4,
            borderRadius: 'sm',
            background: (theme:any) =>
                `linear-gradient(45deg, ${theme.vars.palette.neutral[800]}, ${theme.vars.palette.neutral[600]})`,
            },
            applySolidInversion('neutral'),
        ]}>
            <div>
                <Typography sx={{ mb: 2 }}>
                  {props.description}
                </Typography>
                <Button variant="soft">Оформить</Button>  {/* прикрутить страницу оформления заказа*/}
            </div>
            <Box
            sx={{
                display: 'grid',
                gridTemplateColumns: {
                xs: 'repeat(auto-fill, minmax(min(100%, 180px), 1fr))',
                sm: '1fr 1fr',
                },
                gap: 3,
            }}>
                <Stat value={props.stat3} description="Тариф" />
                <Stat value={props.stat1} description="Цена" />
                <Stat value={props.stat2} description="Индивидуальное использование" />
                <Stat value={props.stat4} description="Корпоративное использование" />
            </Box>
        </Box>
    </div>
  );
}
export {Price}
