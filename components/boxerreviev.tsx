'use client'
import {Reviews} from '@/components/review'
import { Grid } from '@mui/material'
const Boxer = () => {
    const data:number[] = [...Array(13)].map(e=>~~(Math.random()*2))
    return(
        <Grid container rowSpacing={1} columnSpacing={{ xs: 1, sm: 2, md: 3 }}>
         {
            data.map((e:any) => {
                return(
                    <Reviews key={e}/>
                )
            })
        }
       </Grid>
    )
} 
export {Boxer}