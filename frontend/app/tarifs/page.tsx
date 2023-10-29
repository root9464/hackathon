

import {Box} from '@/components/utilprice';
import { Metadata } from "next"
// import Props from '@/components/price'
export const metadata:Metadata = {
    title: "Tarifs | Next app"
} 
export default function Tarifs(){
   
    return (
        <section className="container-tarif">
            <Box/>
        </section>
    )
}
