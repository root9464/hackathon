
import Image from "next/image"
import bc from "@/img/main-bc.jpg"
import KeyboardArrowDownIcon from '@mui/icons-material/KeyboardArrowDown';
import { Button, IconButton } from "@mui/material";

const Main = () => {
    return(
        <section className="block1">
            <Image className="background" src={bc} alt="bc"></Image>
            <IconButton aria-label="fingerprint" href="#target1">
                <KeyboardArrowDownIcon className="button"/>
            </IconButton>
        </section>
    )
}
export { Main }