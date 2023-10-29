'use client'
import { styled } from '@mui/material/styles';
import Box from '@mui/material/Box';
import Rating from '@mui/material/Rating';
import FavoriteIcon from '@mui/icons-material/Favorite';
import FavoriteBorderIcon from '@mui/icons-material/FavoriteBorder';
import Typography from '@mui/material/Typography';

const StyledRating = styled(Rating)({
  '& .MuiRating-iconFilled': {
    color: '#ff6d75',
  },
  '& .MuiRating-iconHover': {
    color: '#ff3d47',
  },
});

const Reviews = () => {

    return(
        <div className='rew'>
            <Box
            className='box'
            sx={{
                '& > legend': { mt: 2 },
            }}
            >
                <Typography component="legend" color={{color:'#000000'}}> Отзыв пользователя</Typography>
                <StyledRating

                    name="customized-color"
                    defaultValue={4}
                    getLabelText={(value: number) => `${value} Heart${value !== 1 ? 's' : ''}`}
                    precision={0.5}
                    readOnly
                    max={7}
                    icon={<FavoriteIcon fontSize="inherit" />}
                    emptyIcon={<FavoriteBorderIcon fontSize="inherit"  />}
                />
            <p>Очень хороший сайт разработчик самый лучший безсомненно </p>
            </Box>
    
        </div>
    )
}
export { Reviews }