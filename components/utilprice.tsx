'use client'
import {Price} from '@/components/price'
import { useState } from 'react'
const Box = () => {
    type Data = {
        description: string
        stat1: string | number
        stat2: string | number
        stat3: string | number
        stat4: string | number
    }
    const [data, SetData] = useState<Data[]>([
        {description:'{описание тарифа}', stat1:'0$', stat2:'99K', stat3:'Бесплатный', stat4:'198K'},
        {description:'{описание тарифа}', stat1:'12$', stat2:'38K', stat3:'Малый', stat4:'91K'},
        {description:'{описание тарифа}', stat1:'30$', stat2:'6K', stat3:'Бизнес', stat4:'80K'},
        {description:'{описание тарифа}', stat1:'100$', stat2:'2K', stat3:'Предприятие', stat4:'78K'},
        {description:'{описание тарифа}', stat1:'400$', stat2:'0.1K', stat3:'Корпорация', stat4:'11'},
    ])
    return(
       <>
        {
            data.map((e:any) => {
                return(
                    <Price props={e} key={e} />
                )
            })
        }
       </>
    )
}
export { Box }