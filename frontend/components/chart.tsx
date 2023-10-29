'use client'

 import { PieChart, pieArcClasses } from '@mui/x-charts/PieChart';
const Chart = () => {
    type datatype = {
        id: number
        value: number
        label: string
    }

    const data:datatype[] = [
        { id: 0, value: 10, label: 'рабочие A' },
        { id: 1, value: 15, label: 'рабочие B' },
        { id: 2, value: 20, label: 'рабочие C' },
        { id: 3, value: 30, label: 'рабочие D' },
    ];
    const color:string[] = [
        '#B6FFFA', '#98E4FF', '#80B3FF', '#687EFF'
    ]
    return(
        <PieChart
        margin={{ top: 100, bottom: 10, left: 10, right:100 }}
        colors={color}
        series={[
          {
            data,
            highlightScope: { faded: 'global', highlighted: 'item' },
            faded: { innerRadius: 30, additionalRadius: -30 },
          },
        ]}
        slotProps={{
            legend: {
              labelStyle: {
                fontSize: 14,
                fill: '#F2F2F2',
              }},
        }}
        sx={{
          [`& .${pieArcClasses.faded}`]: {
            fill: 'white',
          },
        }}
        height={500}
        width={600}
      />
    )
}
export {Chart}